using UnityEngine;

[CreateAssetMenu(fileName = "HamaData", menuName = "Scriptable Objects/HamaData")]
public class HamaData : ScriptableObject
{
    public string namaHama;
    [TextArea(3, 5)]
    public string deskripsi;
    public Sprite gambar;
    public GameObject prefab3D;
}
