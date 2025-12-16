using UnityEngine;

public class PanelInfo : MonoBehaviour
{
    // GANTI NAMA DI SINI (Jangan sama dengan nama Class 'PanelInfo')
    // Saya ganti jadi 'objekPanel'
    public GameObject objekPanel; 

    public void BukaTutupInfo()
    {
        // Cek variable yang baru diganti namanya tadi
        if (objekPanel != null)
        {
            bool statusSekarang = objekPanel.activeSelf;
            objekPanel.SetActive(!statusSekarang);
        }
    }
}