using TheIce.BL;
using TheIce.Core;
using TheIce.DI;

namespace TheIce.API
{
    public class IoCImpl
    {
        public IoCImpl()
        {
        }

        #region Public methods

        public void Configure()
        {
            IoCC.Instance.Register<IHttpGetRequestSender>(new HttpGetRequestSender());
        }

        #endregion Public methods
    }
}