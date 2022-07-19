using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsLearning.Mediator.Mediator;

namespace PatternsLearning.Mediator.Services
{
    internal abstract class BaseService
    {
        protected IMediator _mediator;

        protected BaseService(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }
}
