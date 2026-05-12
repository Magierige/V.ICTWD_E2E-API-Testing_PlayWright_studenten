using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightTests
{
    [TestClass]
    public class Oefening3 : BasePageTest
    {
        //[TestMethod]
        //public async Task inloggen()
        //{
        //    var nameInput = Page.GetByRole("input",{ name: "name" });
        //    nameInput.InputValueAsync("John");
        //    var submit Page.GetByRole('button', { name: 'Submit'});
        //    await Expect(submit).Tohave(true);
        //}
        [TestMethod]
        public async Task Inloggen()
        {
            await Page.GotoAsync("/oefening3.html");

            await Page.GetByTestId("input-name").FillAsync("John");
            await Page.GetByTestId("btn-submit").ClickAsync();
            await Expect(Page.Locator("#signout-form")).ToContainTextAsync("Welkom John!");
        }
    }
}
