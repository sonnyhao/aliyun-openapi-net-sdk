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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class ScreenChestCTResponseUnmarshaller
    {
        public static ScreenChestCTResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ScreenChestCTResponse screenChestCTResponse = new ScreenChestCTResponse();

			screenChestCTResponse.HttpResponse = _ctx.HttpResponse;
			screenChestCTResponse.Message = _ctx.StringValue("ScreenChestCT.Message");
			screenChestCTResponse.RequestId = _ctx.StringValue("ScreenChestCT.RequestId");
			screenChestCTResponse.Code = _ctx.StringValue("ScreenChestCT.Code");

			ScreenChestCTResponse.ScreenChestCT_Data data = new ScreenChestCTResponse.ScreenChestCT_Data();

			ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_Covid covid = new ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_Covid();
			covid.NewProbability = _ctx.StringValue("ScreenChestCT.Data.Covid.NewProbability");
			covid.OtherProbability = _ctx.StringValue("ScreenChestCT.Data.Covid.OtherProbability");
			covid.NormalProbability = _ctx.StringValue("ScreenChestCT.Data.Covid.NormalProbability");
			covid.Mask = _ctx.StringValue("ScreenChestCT.Data.Covid.Mask");
			covid.LesionRatio = _ctx.StringValue("ScreenChestCT.Data.Covid.LesionRatio");
			data.Covid = covid;

			ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_CACS cACS = new ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_CACS();
			cACS.Score = _ctx.StringValue("ScreenChestCT.Data.CACS.Score");
			cACS.ResultUrl = _ctx.StringValue("ScreenChestCT.Data.CACS.ResultUrl");
			data.CACS = cACS;

			ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule lungNodule = new ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule();

			List<ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule.ScreenChestCT_Serie> lungNodule_series = new List<ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule.ScreenChestCT_Serie>();
			for (int i = 0; i < _ctx.Length("ScreenChestCT.Data.LungNodule.Series.Length"); i++) {
				ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule.ScreenChestCT_Serie serie = new ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule.ScreenChestCT_Serie();
				serie.Report = _ctx.StringValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Report");
				serie.SeriesInstanceUid = _ctx.StringValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].SeriesInstanceUid");

				List<string> serie_origin = new List<string>();
				for (int j = 0; j < _ctx.Length("ScreenChestCT.Data.LungNodule.Series["+ i +"].Origin.Length"); j++) {
					serie_origin.Add(_ctx.StringValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Origin["+ j +"]"));
				}
				serie.Origin = serie_origin;

				List<string> serie_spacing = new List<string>();
				for (int j = 0; j < _ctx.Length("ScreenChestCT.Data.LungNodule.Series["+ i +"].Spacing.Length"); j++) {
					serie_spacing.Add(_ctx.StringValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Spacing["+ j +"]"));
				}
				serie.Spacing = serie_spacing;

				List<ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule.ScreenChestCT_Serie.ScreenChestCT_Element> serie_elements = new List<ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule.ScreenChestCT_Serie.ScreenChestCT_Element>();
				for (int j = 0; j < _ctx.Length("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements.Length"); j++) {
					ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule.ScreenChestCT_Serie.ScreenChestCT_Element element = new ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_LungNodule.ScreenChestCT_Serie.ScreenChestCT_Element();
					element.ImageZ = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].ImageZ");
					element.ImageY = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].ImageY");
					element.ImageX = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].ImageX");
					element.Lobe = _ctx.StringValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].Lobe");
					element.Category = _ctx.StringValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].Category");
					element.Lung = _ctx.StringValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].Lung");
					element.MeanValue = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].MeanValue");
					element.Volume = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].Volume");
					element.Confidence = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].Confidence");
					element.X = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].X");
					element.Y = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].Y");
					element.Z = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].Z");
					element.SOPInstanceUID = _ctx.StringValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].SOPInstanceUID");
					element.Diameter = _ctx.FloatValue("ScreenChestCT.Data.LungNodule.Series["+ i +"].Elements["+ j +"].Diameter");

					serie_elements.Add(element);
				}
				serie.Elements = serie_elements;

				lungNodule_series.Add(serie);
			}
			lungNodule.Series = lungNodule_series;
			data.LungNodule = lungNodule;

			ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_DetectRibFracture detectRibFracture = new ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_DetectRibFracture();
			detectRibFracture.ResultURL = _ctx.StringValue("ScreenChestCT.Data.DetectRibFracture.ResultURL");

			List<string> detectRibFracture_origin1 = new List<string>();
			for (int i = 0; i < _ctx.Length("ScreenChestCT.Data.DetectRibFracture.Origin.Length"); i++) {
				detectRibFracture_origin1.Add(_ctx.StringValue("ScreenChestCT.Data.DetectRibFracture.Origin["+ i +"]"));
			}
			detectRibFracture.Origin1 = detectRibFracture_origin1;

			List<string> detectRibFracture_spacing2 = new List<string>();
			for (int i = 0; i < _ctx.Length("ScreenChestCT.Data.DetectRibFracture.Spacing.Length"); i++) {
				detectRibFracture_spacing2.Add(_ctx.StringValue("ScreenChestCT.Data.DetectRibFracture.Spacing["+ i +"]"));
			}
			detectRibFracture.Spacing2 = detectRibFracture_spacing2;

			List<ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_DetectRibFracture.ScreenChestCT_DetectionsItem> detectRibFracture_detections = new List<ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_DetectRibFracture.ScreenChestCT_DetectionsItem>();
			for (int i = 0; i < _ctx.Length("ScreenChestCT.Data.DetectRibFracture.Detections.Length"); i++) {
				ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_DetectRibFracture.ScreenChestCT_DetectionsItem detectionsItem = new ScreenChestCTResponse.ScreenChestCT_Data.ScreenChestCT_DetectRibFracture.ScreenChestCT_DetectionsItem();
				detectionsItem.FractureCategory = _ctx.LongValue("ScreenChestCT.Data.DetectRibFracture.Detections["+ i +"].FractureCategory");
				detectionsItem.FractureConfidence = _ctx.FloatValue("ScreenChestCT.Data.DetectRibFracture.Detections["+ i +"].FractureConfidence");
				detectionsItem.FractureId = _ctx.LongValue("ScreenChestCT.Data.DetectRibFracture.Detections["+ i +"].FractureId");

				List<string> detectionsItem_coordinateImage = new List<string>();
				for (int j = 0; j < _ctx.Length("ScreenChestCT.Data.DetectRibFracture.Detections["+ i +"].CoordinateImage.Length"); j++) {
					detectionsItem_coordinateImage.Add(_ctx.StringValue("ScreenChestCT.Data.DetectRibFracture.Detections["+ i +"].CoordinateImage["+ j +"]"));
				}
				detectionsItem.CoordinateImage = detectionsItem_coordinateImage;

				List<string> detectionsItem_coordinates = new List<string>();
				for (int j = 0; j < _ctx.Length("ScreenChestCT.Data.DetectRibFracture.Detections["+ i +"].Coordinates.Length"); j++) {
					detectionsItem_coordinates.Add(_ctx.StringValue("ScreenChestCT.Data.DetectRibFracture.Detections["+ i +"].Coordinates["+ j +"]"));
				}
				detectionsItem.Coordinates = detectionsItem_coordinates;

				detectRibFracture_detections.Add(detectionsItem);
			}
			detectRibFracture.Detections = detectRibFracture_detections;
			data.DetectRibFracture = detectRibFracture;
			screenChestCTResponse.Data = data;
        
			return screenChestCTResponse;
        }
    }
}
