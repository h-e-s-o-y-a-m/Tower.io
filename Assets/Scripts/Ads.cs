using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class Ads : MonoBehaviour
{
    private string gameId = "******", type = "Rewarded_Android";
    private bool testMode = true;
    private static int countLoses = 1;

    private void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, testMode);
            countLoses++;
            if (countLoses % 3 == 0)
            {
                Advertisement.Show(type);
            }
        }
    }
}