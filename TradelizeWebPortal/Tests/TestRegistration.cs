using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradelizeWebPortal.Settings;

namespace TradelizeWebPortal.Tests
{
    public class TestRegistration : Browser
    {
        [Test]
        public void RegTest()
        {
            reg.OpenRegPage();
            reg.InputSignUpData();
            reg.ClickRegButton();
            // wait 10 sec
            System.Threading.Thread.Sleep(10000);


        }
    }
}
