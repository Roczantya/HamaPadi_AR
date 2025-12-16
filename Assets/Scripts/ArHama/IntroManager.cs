using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public GameObject introPanel; // Masukkan Panel Intro di sini via Inspector

    void Start()
    {
        // Langsung nyalakan panel setiap kali aplikasi/scene dimulai
        // Tidak perlu cek PlayerPrefs
        introPanel.SetActive(true);
    }

    // Panggil fungsi ini di tombol "Tutup" atau "Mengerti" pada Panel
    public void TutupIntro()
    {
        // Hanya matikan panel saat tombol ditekan
        introPanel.SetActive(false);
        
        // Kita tidak perlu menyimpan PlayerPrefs.SetInt, 
        // supaya nanti kalau aplikasi dibuka lagi, dia muncul lagi dari Start().
    }
}