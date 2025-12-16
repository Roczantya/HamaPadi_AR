// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;

// public class HamaSelector : MonoBehaviour
// {
//     // --- Diisi di Inspector ---
//     [Header("Data & Prefab")]
//     [Tooltip("Seret SEMUA file HamaData.asset (Wereng, Belalang, dll.) ke sini.")]
//     public HamaData[] allHamaData; 
    
//     [Tooltip("Seret Prefab Tombol Galeri (HamaItemTemplate) di sini.")]
//     public GameObject hamaItemPrefab; 

//     [Header("Scene Settings")]
//     [Tooltip("Nama Scene AR Anda, misalnya: 'ARScene'.")]
//     public string arSceneName = "ARScene"; 

//     void Start()
//     {
//         // Panggil fungsi untuk mengisi galeri saat scene dimulai
//         LoadGallery();
//     }

//     void LoadGallery()
//     {
//         // Pencegahan: Pastikan semua slot di Inspector sudah terisi
//         if (allHamaData == null || hamaItemPrefab == null)
//         {
//             Debug.LogError("HamaData atau HamaItemPrefab belum diisi di Inspector!");
//             return;
//         }

//         // 1. Bersihkan konten lama (jika ada)
//         foreach (Transform child in transform)
//         {
//             Destroy(child.gameObject);
//         }

//         // 2. Iterasi dan Buat Item
//         foreach (HamaData data in allHamaData)
//         {
//             // Buat instance tombol dari Prefab
//             GameObject item = Instantiate(hamaItemPrefab, transform);
            
//             // 3. Ambil komponen yang diperlukan
//             Button button = item.GetComponent<Button>();
            
//             // Asumsi: Nama dan Icon ada sebagai child/komponen di dalam Prefab Tombol
//             TextMeshProUGUI nameText = item.GetComponentInChildren<TextMeshProUGUI>();
//             Image iconImage = item.transform.Find("IconImage").GetComponent<Image>();
            
//             // 4. Isi data visual
//             if (nameText != null)
//                 nameText.text = data.namaHama;
            
//             if (iconImage != null && data.icon != null)
//                 iconImage.sprite = data.icon; 
            
//             // 5. Tambahkan fungsi klik
//             button.onClick.AddListener(() => SelectAndLoad(data));
//         }
//     }

//     void SelectAndLoad(HamaData selectedData)
//     {
//         // PENTING: Menyimpan data yang dipilih secara global sebelum pindah Scene
//         GlobalHamaHolder.selectedHamaData = selectedData; 

//         // Muat Scene AR
//         UnityEngine.SceneManagement.SceneManager.LoadScene(arSceneName);
//     }
// }