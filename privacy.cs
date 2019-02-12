using System;
using System.Windows;
using MS.Internal.Privacy;
using MS.Internal.Security.Configuration;

public class PrivacyDemo
{
    public static void TestConsent()
    {
        ConsentDialog cd = new ConsentDialog();
        
        // Define dummy app data
        ApplicationInfo meta = new ApplicationInfo();
        meta.ApplicationName = "Foxlet's Big Adventure";
        meta.Manifest = "manifest";
        meta.ProviderName = "FurCode";
        meta.Version = new Version(4, 0, 2, 0);
        
        // Five score risks exist, NoRisk, LowRisk, MediumRisk, HighRisk, MaxRisk
        ScoreResultCollection scores = new ScoreResultCollection();
        scores.Add(new ScoreResult(ScoreRiskBucket.MediumRisk, "This application does not attempt to be functional and is a literal security hole."));
        
        cd.GetConsent(null, meta, scores);
    }
    
    [STAThread]
    public static void Main()
    {
        // Fetch executable name to determine the demo
        string demo = System.AppDomain.CurrentDomain.FriendlyName.ToLower();
        
        switch (demo)
        {
            case "privacy.exe":
                // Show Trust Preferences
                TrustCenter tc = new TrustCenter();
                tc.Start();
                break;
            case "consent.exe":
                // Show dummy Consent Dialog
                TestConsent();
                break;
            default:
                TestConsent();
                break;
        }
    }
}
