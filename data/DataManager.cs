using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : DataManagerBase<DataManager>
{
	public MasterItem master_item;
	public List<MasterItemParam> master_item_list;

	public override void Initialize()
	{
		base.Initialize();
		master_item = new MasterItem();

		for (int i = 0; i < 10; i++)
		{
			MasterItemParam p = new MasterItemParam();
			p.item_id = i + 1;
			master_item.list.Add(p);
		}

	}


}
