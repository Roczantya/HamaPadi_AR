using UnityEngine;
using TMPro; // Jika Anda menggunakan TextMeshPro untuk menampilkan nama
public class HamaController : MonoBehaviour
{
    public HamaData dataHama;
    // Ubah ini menjadi referensi ke komponen Canvas/Panel yang menampung UI
    public GameObject Panel_Info; // Slot untuk Panel info di Hierarchy

    void Start()
    {
        // Pastikan Panel Info diset aktif (jika ingin langsung terlihat)
        Panel_Info.SetActive(true); 
        TampilkanDataHama();
    }
    
    // Fungsi untuk menampilkan/mengupdate data di UI
    public void TampilkanDataHama()
    {
        if (dataHama != null && Panel_Info != null)
        {
            // Ambil referensi ke komponen Text di dalam Panel Info
         // Cari objek dengan nama "HamaNameText" dan "HamaDescText"
        TextMeshProUGUI namaDisplay = Panel_Info.transform.Find("HamaNameText").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI deskripsiDisplay = Panel_Info.transform.Find("HamaDescText").GetComponent<TextMeshProUGUI>();

            // Update teks
            namaDisplay.text = dataHama.namaHama;
            deskripsiDisplay.text = dataHama.deskripsi;
        }
    }
    
    // Gunakan OnValidate() di sini agar perubahan SO terlihat di Editor
    private void OnValidate() 
    {
        TampilkanDataHama();
    }
}