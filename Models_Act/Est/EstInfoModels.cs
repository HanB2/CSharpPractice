﻿using comm_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_esm.Models_Act.Comm;

namespace web_esm.Models_Act.Est
{
    public class EstInfoModels : SeachModel
	{

		public string viewEstCode { get; set; }   //Station


		//페이징
		public PagingModel Paging { get; set; }

		//뷰
		public EsmStation Item { get; set; }

		//리스트 
		public List<EsmStation> Items { get; set; }


		//국가 셀렉트 박스 데이터 세팅
		public List<schTypeArray> schTypeArray = new List<schTypeArray> {
			new schTypeArray {      opt_key = "중요공지",        opt_value = "1"    },
			new schTypeArray {      opt_key = "일반공지",        opt_value = "2" },
			new schTypeArray {      opt_key = "업데이트",        opt_value = "3" }
		};


		//검색조건 셀렉트 박스 데이터 세팅
		public List<schTypeArray> schTypeTxtArray = new List<schTypeArray> {
			new schTypeArray {      opt_key = "번호",        opt_value = "SEQNO" },
			new schTypeArray {      opt_key = "STATION",        opt_value = "EST_CODE" },
			new schTypeArray {      opt_key = "국가",        opt_value = "NATION_CODE" }
			
		};

		//모델 생성자
		public EstInfoModels()
		{
			this.Paging = new PagingModel();
			this.Item = new EsmStation();
			this.Items = new List<EsmStation>();
			this.stationArray = new List<schTypeArray>();
			this.nationArray = new List<schTypeArray>();
		}

		//국가
		public List<schTypeArray> nationArray { get; set; }

		//STATION 셀렉트 박스 데이터 세팅
		public List<schTypeArray> stationArray { get; set; }
		public string station { get; set; }   //Station

	}
}