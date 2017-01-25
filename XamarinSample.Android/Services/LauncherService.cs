using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using A = Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSample.Core.Services;
using System.Threading.Tasks;
using Android.Provider;

namespace XamarinSample.Android.Services {
    public class LauncherService : ILauncherService {
        public void DialPhoneNumber(string name, string phoneNumber) {
            var uri = A.Net.Uri.Parse("tel:" + phoneNumber);
            var intent = new Intent(Intent.ActionDial, uri);
            intent.AddFlags(ActivityFlags.NewTask);
            Application.Context.StartActivity(intent);
        }

        public Task<string> LaunchCamera(string fileName) {
            TaskCompletionSource<string> task = new TaskCompletionSource<string>();

            Intent takePictureIntent = new Intent(MediaStore.ActionImageCapture);

            var dir = new Java.IO.File(
                A.OS.Environment.GetExternalStoragePublicDirectory(
                A.OS.Environment.DirectoryPictures), "PersonPhotos");

            if (!dir.Exists()) {
                dir.Mkdirs();
            }

            var _file = new Java.IO.File(dir, fileName + ".jpg");
            takePictureIntent.PutExtra(MediaStore.ExtraOutput, A.Net.Uri.FromFile(_file));

            if (takePictureIntent.ResolveActivity(Application.Context.PackageManager) != null) {
                App.CurrentActivity.ActivityResult += (s, e) => {
                    switch (e) {
                        case Result.Canceled:
                            task.SetResult("");
                            break;
                        case Result.FirstUser:
                            break;
                        case Result.Ok:
                            if (task.Task.Status == TaskStatus.WaitingForActivation) {
                                task.SetResult(_file.AbsolutePath);
                            }
                            break;
                        default:
                            break;
                    }

                };
                App.CurrentActivity.StartActivityForResult(takePictureIntent, 0);

            }


            return task.Task;
        }

        public void SendEmail(string to) {
            var intent = new Intent(Intent.ActionSend);
            intent.PutExtra(Intent.ExtraEmail, new[] { to });
            intent.AddFlags(ActivityFlags.NewTask);
            intent.SetType("message/rfc822");
            Application.Context.StartActivity(intent);
        }

        public void SendEmail(string subject, string emailText) {
            var intent = new Intent(Intent.ActionSend);
            intent.PutExtra(Intent.ExtraSubject, subject);
            intent.PutExtra(Intent.ExtraText, emailText);
            intent.AddFlags(ActivityFlags.NewTask);
            intent.SetType("message/rfc822");
            Application.Context.StartActivity(intent);
        }
    }
}