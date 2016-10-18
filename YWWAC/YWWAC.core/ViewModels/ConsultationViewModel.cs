using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Plugins.PhoneCall;
using System.Windows.Input;


namespace YWWAC.core.ViewModels
{
    public class ConsultationViewModel : MvxViewModel
    {
        public ICommand CallGeneralCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    MvvmCross.Plugins.PhoneCall.PluginLoader.Instance.EnsureLoaded();
                    Mvx.Resolve<IMvxPhoneCallTask>().MakePhoneCall("Contact us", "0421735850");
                });
            }
        }
    }
}
