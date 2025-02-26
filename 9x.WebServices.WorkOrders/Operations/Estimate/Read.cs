﻿using CorrigoServiceWebReference.CorrigoGA;
using System.Diagnostics;

namespace _9x.WebServices.WorkOrders.Operations.Estimate
{
	internal static class Read
	{
		public static WoEstimate Retrieve (CorrigoService service, int estimateId)
		{
			Debug.Print($"Retrieving WoEstimate with id '{estimateId}'");

			var specifier = new EntitySpecifier { EntityType = EntityType.WoEstimate, Id = estimateId };
			string[] properties =
			{
				"Id", "ConcurrencyId",
				"Amount", "Comment", "ContactName","Reason", "StatusId",
			};
			var response = service.Retrieve(specifier, new PropertySet { Properties = properties })
						 as WoEstimate;

			Debug.Print(response == null ? "Failure!" : "Success!");
			return response;
		}
	}
}
