using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradelizeWebPortal.Settings;

namespace TradelizeWebPortal.Tests
{
    public class TestMirroringModalWindows : Browser

    {
        [Test]
        
        // Для проверки работает ли правильно метод
        public void Action1A()
        {
            log.OpenLoginPage();

            log.SignInByLogin();

            Thread.Sleep(5000);

            mir.OpenMirroringPage();

            mir.CurrentOffersON();

            Thread.Sleep(5000);
        }
    }
}
