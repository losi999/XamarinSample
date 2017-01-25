using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinSample.API.Core;

namespace XamarinSample.API.Controllers {
    public class ControllerBase : Controller {
        protected IUnitOfWork _unitOfWork { get; }

        public ControllerBase(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }
    }
}
