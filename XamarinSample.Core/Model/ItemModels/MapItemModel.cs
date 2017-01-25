using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.Enum;
using XamarinSample.Core.Model.Primitives;

namespace XamarinSample.Core.Model.ItemModels {
    public class MapItemModel : ObservableObject {

        public MapItemModel() {
        }

        public MapItemModel(Coordinate coordinate) {
            Coordinate = coordinate;
            AnchorPoint = AnchorPoint.BottomCenter;
        }

        public int Id { get; }
        public string Title { get; }
        public Coordinate Coordinate { get; }
        public AnchorPoint AnchorPoint { get; }
        private bool _isBubbleVisible;

        public bool IsBubbleVisible {
            get {
                return _isBubbleVisible;
            }

            set {
                _isBubbleVisible = value;
                RaisePropertyChanged(nameof(IsBubbleVisible));
            }
        }
    }
}
