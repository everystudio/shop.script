using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterItemParam : CsvDataParam
{
	public int item_id { get; set; }
	public string name { get; set; }

	public string category_main { get; set; }
	public string category_sub { get; set; }

	public int request_id_1 { get; set; }
	public int request_num_1 { get; set; }
	public int request_id_2 { get; set; }
	public int request_num_2 { get; set; }
	public int request_id_3 { get; set; }
	public int request_num_3 { get; set; }


}

public class MasterItem : CsvData<MasterItemParam>
{
}
