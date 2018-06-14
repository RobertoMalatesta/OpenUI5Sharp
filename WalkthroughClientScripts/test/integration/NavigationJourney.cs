using Bridge;
using System;
using System.Linq;
using static Retyped.qunit;
using OpenUI5Sharp;

namespace WalkthroughClientScripts.Tests
{
    [FileName("test/integration/navigationJourney.js")]
    public class NavigationJourney
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.require(new string[] {
                    "sap/ui/test/opaQunit"
                },
                new Action(() => {
                    QUnit.module("Navigation");

                    Globals.opaTest("Should open the hello dialog", 
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            // Arrangements
                            Given.iStartMyAppInAFrame(jQuery.sap.getResourcePath("sap/ui/demo/app/test", ".html"));

                            //Actions
                            When["onTheAppPage"].As<onTheAppPageAction>().iPressTheSayHelloWithDialogButton();

                            // Assertions
                            Then["onTheAppPage"].As<onTheAppPageAssertion>().iShouldSeeTheHelloDialog();
                            Then["onTheAppPage"].As<onTheAppPageAssertion>().iTeardownMyAppFrame();
                        }
                    );
                })
            );
        }
    }
}
