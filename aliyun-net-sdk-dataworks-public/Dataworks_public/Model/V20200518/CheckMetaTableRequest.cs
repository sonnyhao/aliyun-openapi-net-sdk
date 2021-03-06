/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class CheckMetaTableRequest : RpcAcsRequest<CheckMetaTableResponse>
    {
        public CheckMetaTableRequest()
            : base("dataworks-public", "2020-05-18", "CheckMetaTable")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dataSourceType;

		private string tableGuid;

		private string databaseName;

		private string clusterId;

		private string tableName;

		public string DataSourceType
		{
			get
			{
				return dataSourceType;
			}
			set	
			{
				dataSourceType = value;
				DictionaryUtil.Add(QueryParameters, "DataSourceType", value);
			}
		}

		public string TableGuid
		{
			get
			{
				return tableGuid;
			}
			set	
			{
				tableGuid = value;
				DictionaryUtil.Add(QueryParameters, "TableGuid", value);
			}
		}

		public string DatabaseName
		{
			get
			{
				return databaseName;
			}
			set	
			{
				databaseName = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseName", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string TableName
		{
			get
			{
				return tableName;
			}
			set	
			{
				tableName = value;
				DictionaryUtil.Add(QueryParameters, "TableName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckMetaTableResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckMetaTableResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
