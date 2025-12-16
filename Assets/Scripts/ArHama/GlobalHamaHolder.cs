using UnityEngine;

// Kelas statis untuk menampung data HamaData yang dipilih
// Static class tidak perlu dilekatkan ke GameObject
public static class GlobalHamaHolder
{
    // Variabel statis ini menyimpan data yang dipilih
    // Hanya ada satu instance dari HamaData yang bisa disimpan pada satu waktu
    public static HamaData selectedHamaData;
}