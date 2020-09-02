using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UI
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// A part of Factory Abstruct Pattern.
    /// Concrete creator for windows forms application.
    /// Creates pages with Form type.
    /// </summary>
    public class WinFormAppPagesCreator : AppPagesFactory<Form>
    {
        private readonly User r_User;

        public WinFormAppPagesCreator(User i_User)
        {
            r_User = i_User;
        }

        public override void CreatePages()
        {
            AppPages.Add(new MainPageForm(r_User));
            AppPages.Add(new UserInformation(r_User));
            AppPages.Add(new ZodiacSignForm(r_User));
        }
    }
}
