using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace PlaywrightTests
{
    [TestClass]
    public class Oefening2 : BasePageTest
    {
        [TestMethod]
        public async Task CheckenAantalProducten()
        {
            var filter = new LocatorFilterOptions { Visible = true };
            await Page.GotoAsync("/oefening2.html");
            await Expect(Page.Locator(".product-card").Filter(filter)).ToHaveCountAsync(3);
        }
    }
}
