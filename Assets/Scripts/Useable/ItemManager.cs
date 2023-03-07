using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //private List<ItemSO> _items = new();

    void Awake()
    {
        //_items = Resources.LoadAll<ItemSO>("ScriptableObjects/Items").ToList();
    }

    //public List<ItemSO> GetAll()
    //{
    //    return _items;
    //}

    //public ItemSO Get(string itemName)
    //{
    //    return _items.Find(x => x.Name == itemName);
    //}
}
