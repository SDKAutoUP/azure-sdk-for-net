// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CostManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ViewsOperations.
    /// </summary>
    public static partial class ViewsOperationsExtensions
    {
            /// <summary>
            /// Lists all views by tenant and object.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<View> List(this IViewsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all views by tenant and object.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<View>> ListAsync(this IViewsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all views at the given scope.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with view operations. This includes
            /// 'subscriptions/{subscriptionId}' for subscription scope,
            /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for BillingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
            /// for InvoiceSection scope,
            /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope,
            /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
            /// for External Billing Account scope and
            /// 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
            /// for External Subscription scope.
            /// </param>
            public static IPage<View> ListByScope(this IViewsOperations operations, string scope)
            {
                return operations.ListByScopeAsync(scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all views at the given scope.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with view operations. This includes
            /// 'subscriptions/{subscriptionId}' for subscription scope,
            /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for BillingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
            /// for InvoiceSection scope,
            /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope,
            /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
            /// for External Billing Account scope and
            /// 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
            /// for External Subscription scope.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<View>> ListByScopeAsync(this IViewsOperations operations, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByScopeWithHttpMessagesAsync(scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the view by view name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            public static View Get(this IViewsOperations operations, string viewName)
            {
                return operations.GetAsync(viewName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the view by view name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<View> GetAsync(this IViewsOperations operations, string viewName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(viewName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create or update a view. Update operation requires latest
            /// eTag to be set in the request. You may obtain the latest eTag by performing
            /// a get operation. Create operation does not require eTag.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate View operation.
            /// </param>
            public static View CreateOrUpdate(this IViewsOperations operations, string viewName, View parameters)
            {
                return operations.CreateOrUpdateAsync(viewName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update a view. Update operation requires latest
            /// eTag to be set in the request. You may obtain the latest eTag by performing
            /// a get operation. Create operation does not require eTag.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate View operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<View> CreateOrUpdateAsync(this IViewsOperations operations, string viewName, View parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(viewName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete a view.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            public static void Delete(this IViewsOperations operations, string viewName)
            {
                operations.DeleteAsync(viewName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete a view.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IViewsOperations operations, string viewName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(viewName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the view for the defined scope by view name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with view operations. This includes
            /// 'subscriptions/{subscriptionId}' for subscription scope,
            /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for BillingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
            /// for InvoiceSection scope,
            /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope,
            /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
            /// for External Billing Account scope and
            /// 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
            /// for External Subscription scope.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            public static View GetByScope(this IViewsOperations operations, string scope, string viewName)
            {
                return operations.GetByScopeAsync(scope, viewName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the view for the defined scope by view name.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with view operations. This includes
            /// 'subscriptions/{subscriptionId}' for subscription scope,
            /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for BillingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
            /// for InvoiceSection scope,
            /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope,
            /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
            /// for External Billing Account scope and
            /// 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
            /// for External Subscription scope.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<View> GetByScopeAsync(this IViewsOperations operations, string scope, string viewName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByScopeWithHttpMessagesAsync(scope, viewName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to create or update a view. Update operation requires latest
            /// eTag to be set in the request. You may obtain the latest eTag by performing
            /// a get operation. Create operation does not require eTag.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with view operations. This includes
            /// 'subscriptions/{subscriptionId}' for subscription scope,
            /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for BillingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
            /// for InvoiceSection scope,
            /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope,
            /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
            /// for External Billing Account scope and
            /// 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
            /// for External Subscription scope.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate View operation.
            /// </param>
            public static View CreateOrUpdateByScope(this IViewsOperations operations, string scope, string viewName, View parameters)
            {
                return operations.CreateOrUpdateByScopeAsync(scope, viewName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update a view. Update operation requires latest
            /// eTag to be set in the request. You may obtain the latest eTag by performing
            /// a get operation. Create operation does not require eTag.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with view operations. This includes
            /// 'subscriptions/{subscriptionId}' for subscription scope,
            /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for BillingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
            /// for InvoiceSection scope,
            /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope,
            /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
            /// for External Billing Account scope and
            /// 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
            /// for External Subscription scope.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate View operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<View> CreateOrUpdateByScopeAsync(this IViewsOperations operations, string scope, string viewName, View parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateByScopeWithHttpMessagesAsync(scope, viewName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete a view.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with view operations. This includes
            /// 'subscriptions/{subscriptionId}' for subscription scope,
            /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for BillingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
            /// for InvoiceSection scope,
            /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope,
            /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
            /// for External Billing Account scope and
            /// 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
            /// for External Subscription scope.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            public static void DeleteByScope(this IViewsOperations operations, string scope, string viewName)
            {
                operations.DeleteByScopeAsync(scope, viewName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete a view.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope associated with view operations. This includes
            /// 'subscriptions/{subscriptionId}' for subscription scope,
            /// 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for
            /// resourceGroup scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for
            /// Billing Account scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}'
            /// for Department scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}'
            /// for EnrollmentAccount scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}'
            /// for BillingProfile scope,
            /// 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}'
            /// for InvoiceSection scope,
            /// 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for
            /// Management Group scope,
            /// 'providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}'
            /// for External Billing Account scope and
            /// 'providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}'
            /// for External Subscription scope.
            /// </param>
            /// <param name='viewName'>
            /// View name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByScopeAsync(this IViewsOperations operations, string scope, string viewName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByScopeWithHttpMessagesAsync(scope, viewName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all views by tenant and object.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<View> ListNext(this IViewsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all views by tenant and object.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<View>> ListNextAsync(this IViewsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all views at the given scope.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<View> ListByScopeNext(this IViewsOperations operations, string nextPageLink)
            {
                return operations.ListByScopeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all views at the given scope.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/costmanagement/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<View>> ListByScopeNextAsync(this IViewsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
