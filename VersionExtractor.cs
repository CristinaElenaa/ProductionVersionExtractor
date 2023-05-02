using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionVersionExtractor
{
    public class VersionExtractor
    {
        public string GetProductionVersion(List<string> versions)
        {
            Version productionVersion = null;
            foreach (string version in versions)
            {
                string[] versionParts = version.Split('-');
                string[] versionNumbers = versionParts[0].Split('.');
                if (versionNumbers.Length < 3)
                {
                    continue;
                }

                Version currentVersion = new Version(
                    int.Parse(versionNumbers[0]),
                    int.Parse(versionNumbers[1]),
                    int.Parse(versionNumbers[2]));

                if (productionVersion == null || currentVersion > productionVersion)
                {
                    productionVersion = currentVersion;
                }
            }

            return productionVersion?.ToString();
        }


    }
}
