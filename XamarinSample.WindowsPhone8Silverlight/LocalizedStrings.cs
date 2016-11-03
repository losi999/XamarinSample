﻿using XamarinSample.WindowsPhone8Silverlight.Resources;

namespace XamarinSample.WindowsPhone8Silverlight {
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}