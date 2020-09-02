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

        public override void CreatePages()
        {
            AppPages.Add(new MainPageForm());
            AppPages.Add(new UserInformation());
            AppPages.Add(new ZodiacSignForm());
        }
    }
}
