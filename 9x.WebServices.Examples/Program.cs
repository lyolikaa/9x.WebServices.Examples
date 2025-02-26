﻿using _9x.WebServices.Actors;
using _9x.WebServices.Contracts;
using _9x.WebServices.Customers;
using _9x.WebServices.Locations;
using _9x.WebServices.RepairCodes;
using _9x.WebServices.WoActionLogs;
using _9x.WebServices.WorkOrders;
using _9x.WebServices.WorkOrders.Workflows;
using _9xWebServices.Spaces;
using CorrigoServiceWebReference;
using OneTransactionCommands;
using System;
using System.Diagnostics;


namespace _9x.WebServices.Examples
{
	class Program
	{
		private const string Company = "Integrations 9.1 DB";
		private const string UserName = "ewi";
		private const string Password = "Corrigo2!";

		static readonly CorrigoClientProvider clientProvider = new CorrigoClientProvider();
		static void Main(string[] args)
		{
			try
			{
				//url for qa companies: https://v90g.qa.corrigo.com/wsdk/CorrigoService.asmx
				var service = clientProvider.GetCorrigoService(
					"http://v91.qa.corrigo.com/wsdk/CorrigoService.asmx",
					Company, UserName, Password);

                #region different test cases - to execute - uncomment
                //var id = CustomerExamples.CreateRetreive(service);
                //CustomerExamples.RetreiveUpdate(service, id);
                //CustomerExamples.Delete(service, id);

                //var createResponse = SpaceExamples.CreateSpaceByUnitId(service, 73);
                //var space = SpaceExamples.ReadSpace(service, createResponse.NewSpace?.Id ?? 45);
                //var updateByIdResponse = SpaceExamples.UpdateSpaceById(service, space.Id);
                //var updateResponse = SpaceExamples.UpdateSpaceByInstance(service, space);                
                //var deleteResponse = SpaceExamples.DeleteSpace(service, updateResponse?.EntitySpecifier?.Id ?? 46);

                //_9x.WebServices.WoPriorities.WoPriorityExamples.CRUDExample(service);
                //_9x.WebServices.Employees.EmployeeExamples.CRUDExample(service);
                //_9x.WebServices.BillingAccounts.BillingAccountExamples.CRUDExample(service);
                //_9x.WebServices.WoActionLogs.WoActionLogExamples.CRUDExample(service);
                //_9x.WebServices.WoLastActions.WoLastActionExamples.CRUDExample(service);
                //_9x.WebServices.Tasks.TaskExamples.CRUDExample(service);
                //_9x.WebServices.Specialties.SpecialtyExamples.CRUDExample(service);
                //_9x.WebServices.WorkZones.WorkZoneExamples.CRUDExample(service);
                //_9x.WebServices.Contracts.ContractExamples.CRUDExample(service);
                //_9x.WebServices.Addresses.Address2Examples.CRUDExample(service);
                //_9x.WebServices.Contacts.ContactExamples.CRUDExample(service);
                //_9x.WebServices.Documents.DocumentExamples.CRUDExample(service);
                //_9x.WebServices.AssetTrees.AssetTreeExamples.CRUDExample(service);
                //_9x.WebServices.Organizations.OrganizationExamples.CRUDExample(service);
                //_9x.WebServices.CustomField2s.CustomField2Examples.CRUDExample(service);

                //WorkOrderOperationExamples.CreateWorkOrderAndUpdateCustomFields(service);
                //var readWO = WorkOrderOperationExamples.RetrieveWorkOrder(service, WoActionLogExamples.GetLatestWOs(service,1)[0].Id);
                //var woCancellationResponse = WorkOrderOperationExamples.DeleteWorkOrder(service, readWO.Id);

                //int workOrderId = WoActionLogExamples.GetLatestWOs(service, 2)[1].Id;
                //WorkOrderWorkflowExamples.Assign(service, workOrderId);
                //WorkOrderWorkflowExamples.PickUp(service, workOrderId);
                //WorkOrderWorkflowExamples.Start(service, workOrderId);
                //WorkOrderWorkflowExamples.Pause(service, workOrderId);
                //WorkOrderWorkflowExamples.Reopen(service, workOrderId);
                //WorkOrderWorkflowExamples.OnHold(service, workOrderId);
                //WorkOrderWorkflowExamples.Cancel(service, workOrderId);
                //WorkOrderWorkflowExamples.Complete(service, workOrderId);

                //WorkOrderWorkflowExamples.NewToPause(service, workOrderId);
                //WorkOrderWorkflowExamples.NewToOnHoldThroughPause(service, workOrderId);
                //WorkOrderWorkflowExamples.NewToCompleteThroughCancel(service, workOrderId);

                //var noteId = WorkOrderNotesExamples.CreateNote(service, workOrderId);
                //WorkOrderNotesExamples.UpdateNote(service, workOrderId, noteId);
                //WorkOrderNotesExamples.ReadNote(service, noteId);
                //WorkOrderNotesExamples.DeleteNote(service, workOrderId, noteId);

                //var costId = WorkOrderCostsExamples.CreateCosts(service);
                //var woCost = WorkOrderCostsExamples.ReadCosts(service, WoActionLogExamples.GetLatestWOs(service, 1)[0].Id);

                //var repairCategoryId = RepairCodeExamples.CreateRepairCategory(service);
                //var repairCodeId = RepairCodeExamples.CreateRepairCode(service, repairCategoryId);
                //RepairCodeExamples.UpdateDisplayAs(service, repairCategoryId);
                //RepairCodeExamples.UpdateParentId(service, repairCategoryId);	//is not possible
                //RepairCodeExamples.AddChildRepairCodes(service);				// is not possible
                // method doesn't return error but doesn't change anything
                // RepairCodeExamples.RemoveChildRepairCodes(service);
                //var repairCategory = RepairCodeExamples.RetrieveRepairCode(service, repairCategoryId);
                //var repairCode = RepairCodeExamples.RetrieveRepairCode(service, repairCodeId);
                //RepairCodeExamples.DeleteRepairCode(service, repairCodeId);

                //int estimateWorkOrderId = WoActionLogExamples.GetLatestWOs(service, 1)[0].Id;
                //var estimateId = WorkOrderEstimateExamples.CreateEstimate(service, estimateWorkOrderId);
                //var estimate = WorkOrderEstimateExamples.ReadEstimate(service, estimateId);
                //WorkOrderEstimateExamples.UpdateStatusEstimate(service, estimateWorkOrderId);
                //WorkOrderEstimateExamples.DeleteEstimate(service, estimateWorkOrderId);

                //UnitSpaceContactWorkOrder.Create(service, 34, "SpaceAsset");//"SpaceAsset"=>see by navigation path Assets>TemplateManager> Type="Unit"

                //var assignmentId = WorkOrderAssignmentExamples.CreateAssignment(service, WoActionLogExamples.GetLatestWOs(service, 1)[0].Id);
                //WorkOrderAssignmentExamples.ReadAssignment(service, assignmentId);
                //WorkOrderAssignmentExamples.UpdateAssignment(service, assignmentId);
                //WorkOrderAssignmentExamples.DeleteAssignment(service, assignmentId);

                //WorkOrderActionReasonLookupExamples.ReadActionReasonLookup(service, WoActionLogExamples.GetLatestWOs(service, 1)[0].Id);

                //ActorExamples.CreateAsset(service);
                //ActorExamples.CreateCompanyProp(service);
                //ActorExamples.CreateLeaseUser(service);
                //ActorExamples.ReadActor(service, 3);

                //var locationId = LocationExamples.CreateLocation(service);
                //LocationExamples.ReadLocation(service, locationId);
                //LocationExamples.UpdateLocation(service, locationId);
                //LocationExamples.DeleteLocation(service, locationId);
                #endregion different test cases - to execute - uncomment

                //int itemWorkOrderId = WoActionLogExamples.GetLatestWOs(service, 1)[0].Id;
                //WorkOrderItemExamples.CreateItem(service, itemWorkOrderId);
                //WorkOrderOperationExamples.CreateCustomFieldForWorkOrder(service, itemWorkOrderId);
                //WoScheduleExample.InitializeSchedule(service);
                //WoAutoAssignExample.Execute(service, itemWorkOrderId);
            }
            catch (Exception exc)
			{
				Debug.Print(exc.Message);
				Debug.Print("\n");
				Debug.Print(exc.StackTrace);
			}
		}
	}
}
