namespace WpfApplication2.Data
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Linq;
	using System.Runtime.Serialization;

	/// <summary>
	/// 分相信息表
	/// </summary>
	[Serializable]
	[DataContract]
	public class PhaseSplittingInfo : Sui.ComponentModel.DataModelBase
	{
		#region Fields
		/// <summary>
		/// 顺序号
		/// </summary>
		private int _iD;
		/// <summary>
		/// 批次号
		/// </summary>
		private Guid _groupID;
		/// <summary>
		/// 行向类别
		/// </summary>
		private int _category;
		/// <summary>
		/// 起点里程
		/// </summary>
		private string _startMileage;
		/// <summary>
		/// 终点里程
		/// </summary>
		private string _endMileage;
		/// <summary>
		/// 长度
		/// </summary>
		private int _length;
		/// <summary>
		/// 备注1
		/// </summary>
		private string _remark1;
		/// <summary>
		/// 备注2
		/// </summary>
		private string _remark2;
		#endregion

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PhaseSplittingInfo()
		{
			_iD = int.MinValue;
			_groupID = Guid.NewGuid();
			_category = int.MinValue;
			_startMileage = null;
			_endMileage = null;
			_length = int.MinValue;
			_remark1 = null;
			_remark2 = null;
		}

		/// <summary>
		/// Copy constructor.
		/// </summary>
		public PhaseSplittingInfo(PhaseSplittingInfo source)
		{
			_iD = source.ID;
			_groupID = source.GroupID;
			_category = source.Category;
			_startMileage = source.StartMileage;
			_endMileage = source.EndMileage;
			_length = source.Length;
			_remark1 = source.Remark1;
			_remark2 = source.Remark2;
		}

		/// <summary>
		/// No identity column constructror.
		/// </summary>
		public PhaseSplittingInfo(Guid groupID, int category, string startMileage, string endMileage, int length, string remark1, string remark2)
		{
			_groupID = groupID;
			_category = category;
			_startMileage = startMileage;
			_endMileage = endMileage;
			_length = length;
			_remark1 = remark1;
			_remark2 = remark2;
		}

		/// <summary>
		/// All column constructror.
		/// </summary>
		public PhaseSplittingInfo(int iD, Guid groupID, int category, string startMileage, string endMileage, int length, string remark1, string remark2)
		{
			_iD = iD;
			_groupID = groupID;
			_category = category;
			_startMileage = startMileage;
			_endMileage = endMileage;
			_length = length;
			_remark1 = remark1;
			_remark2 = remark2;
		}

		/// <summary>
		/// Create instance from DataTable which has the structrue of PhaseSplittingInfo.
		/// </summary>
		/// <param name="dr">DataRow Data</param>
		public PhaseSplittingInfo(DataRow dr)
		{
			object data;
			data = dr["ID"];
			if (data == null || string.IsNullOrEmpty(data.ToString()))
			{
				_iD = int.MinValue;
			}
			else
			{
				_iD = int.Parse(data.ToString());
			}
			data = dr["GroupID"];
			if (data == null || string.IsNullOrEmpty(data.ToString()))
			{
				_groupID = Guid.NewGuid();
			}
			else
			{
				_groupID = Guid.Parse(data.ToString());
			}
			data = dr["Category"];
			if (data == null || string.IsNullOrEmpty(data.ToString()))
			{
				_category = int.MinValue;
			}
			else
			{
				_category = int.Parse(data.ToString());
			}
			data = dr["StartMileage"];
			if (data == null || string.IsNullOrEmpty(data.ToString()))
			{
				_startMileage = null;
			}
			else
			{
				_startMileage = data.ToString();
			}
			data = dr["EndMileage"];
			if (data == null || string.IsNullOrEmpty(data.ToString()))
			{
				_endMileage = null;
			}
			else
			{
				_endMileage = data.ToString();
			}
			data = dr["Length"];
			if (data == null || string.IsNullOrEmpty(data.ToString()))
			{
				_length = int.MinValue;
			}
			else
			{
				_length = int.Parse(data.ToString());
			}
			data = dr["Remark1"];
			if (data == null || string.IsNullOrEmpty(data.ToString()))
			{
				_remark1 = null;
			}
			else
			{
				_remark1 = data.ToString();
			}
			data = dr["Remark2"];
			if (data == null || string.IsNullOrEmpty(data.ToString()))
			{
				_remark2 = null;
			}
			else
			{
				_remark2 = data.ToString();
			}
		}

		#endregion

		#region Properties

		/// <summary>
		/// 顺序号
		/// </summary>
		[DataMember]
		public int ID
		{
			get { return _iD; }
			set
			{
				if (Constants.IS_TWOWAY_BINDING)
				{
					SetValue(ref _iD, value, () => this.ID);
				}
				else
				{
					_iD = value;
				}
			}
		}

		/// <summary>
		/// 批次号
		/// </summary>
		[DataMember]
		public Guid GroupID
		{
			get { return _groupID; }
			set
			{
				if (Constants.IS_TWOWAY_BINDING)
				{
					SetValue(ref _groupID, value, () => this.GroupID);
				}
				else
				{
					_groupID = value;
				}
			}
		}

		/// <summary>
		/// 行向类别
		/// </summary>
		[DataMember]
		public int Category
		{
			get { return _category; }
			set
			{
				if (Constants.IS_TWOWAY_BINDING)
				{
					SetValue(ref _category, value, () => this.Category);
				}
				else
				{
					_category = value;
				}
			}
		}

		/// <summary>
		/// 起点里程
		/// </summary>
		[DataMember]
		public string StartMileage
		{
			get { return _startMileage; }
			set
			{
				if (Constants.IS_TWOWAY_BINDING)
				{
					SetValue(ref _startMileage, value, () => this.StartMileage);
				}
				else
				{
					_startMileage = value;
				}
			}
		}

		/// <summary>
		/// 终点里程
		/// </summary>
		[DataMember]
		public string EndMileage
		{
			get { return _endMileage; }
			set
			{
				if (Constants.IS_TWOWAY_BINDING)
				{
					SetValue(ref _endMileage, value, () => this.EndMileage);
				}
				else
				{
					_endMileage = value;
				}
			}
		}

		/// <summary>
		/// 长度
		/// </summary>
		[DataMember]
		public int Length
		{
			get { return _length; }
			set
			{
				if (Constants.IS_TWOWAY_BINDING)
				{
					SetValue(ref _length, value, () => this.Length);
				}
				else
				{
					_length = value;
				}
			}
		}

		/// <summary>
		/// 备注1
		/// </summary>
		[DataMember]
		public string Remark1
		{
			get { return _remark1; }
			set
			{
				if (Constants.IS_TWOWAY_BINDING)
				{
					SetValue(ref _remark1, value, () => this.Remark1);
				}
				else
				{
					_remark1 = value;
				}
			}
		}

		/// <summary>
		/// 备注2
		/// </summary>
		[DataMember]
		public string Remark2
		{
			get { return _remark2; }
			set
			{
				if (Constants.IS_TWOWAY_BINDING)
				{
					SetValue(ref _remark2, value, () => this.Remark2);
				}
				else
				{
					_remark2 = value;
				}
			}
		}

		#endregion

		#region ManualCode
		/***PRESERVE_BEGIN MANUAL_CODE***/
		/***PRESERVE_END MANUAL_CODE***/
		#endregion
	}
}