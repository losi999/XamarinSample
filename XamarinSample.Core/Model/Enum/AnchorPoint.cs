using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.Model.Enum {
    public enum AnchorPoint {
        TopLeft = 11,       // Point 0.0 , 0.0
        TopCenter = 12,     // Point 0.5 , 0.0
        TopRight = 13,      // Point 1.0 , 0.0
        MiddleLeft = 21,    // Point 0.0 , 0.5
        MiddleCenter = 22,  // Point 0.5 , 0.5
        MiddleRight = 23,   // Point 1.0 , 0.5
        BottomLeft = 31,    // Point 0.0 , 1.0
        BottomCenter = 32,  // Point 0.5 , 1.0
        BottomRight = 33    // Point 1.0 , 1.0
    }
}
