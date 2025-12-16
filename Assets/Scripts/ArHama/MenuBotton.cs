using UnityEngine;

public class MenuBotton : MonoBehaviour
{
    public GameObject MenuList;

    // Fungsi ini yang nanti dipanggil saat tombol diklik
    public void BukaTutupMenu()
    {
        // Mengecek: Apakah menu sedang aktif?
        if (MenuList != null)
        {
            // Kalau aktif jadi mati, kalau mati jadi aktif (kebalikannya)
            bool statusSekarang = MenuList.activeSelf;
            MenuList.SetActive(!statusSekarang);
        }
    }

}
