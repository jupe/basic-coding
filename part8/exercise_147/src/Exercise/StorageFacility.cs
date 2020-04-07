using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {
    private Dictionary<string, List<string>> Storage;
    public StorageFacility()
    {
      this.Storage = new Dictionary<string, List<string>>();
    }
    public void Add(string unit, string item)
    {
      if (!this.Storage.ContainsKey(unit)) 
         {
            this.Storage.Add(unit, new List<string>());
         }    
        this.Storage[unit].Add(item);
    }

    public List<string> Contents(string storageUnit)
    {
      if (!this.Storage.ContainsKey(storageUnit)) 
         {
            this.Storage.Add(storageUnit, new List<string>());
         }    
         return this.Storage[storageUnit];
    }

    public void Remove(string storageUnit, string item)
    {
      this.Storage[storageUnit].Remove(item);
      if (this.Storage[storageUnit].Count == 0)
      {
          this.Storage.Remove(storageUnit);
      }
    }

    public List<string> StorageUnits()
    {
      List<string> storageUnitList = new List<string>();
      Dictionary<string, List <string>>.KeyCollection keyes = this.Storage.Keys;
      foreach (string storages in keyes)
      {
        storageUnitList.Add(storages);
      } 
      return storageUnitList;
    }
  }
}