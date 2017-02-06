using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Salesforce.Force;
using IntegrationCFAB.ViewModels;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace IntegrationCFAB.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        

        public async Task<ActionResult> Index()
        {
            var accessToken = Session["AccessToken"].ToString();
            var apiVersion = Session["ApiVersion"].ToString();
            var instanceUrl = Session["InstanceUrl"].ToString();

            var client = new ForceClient(instanceUrl, accessToken, apiVersion);
            var contacts = await client.QueryAsync<ContactsViewModel>("SELECT id, name FROM Contact");

            return View(contacts.records);
        }
    }
}