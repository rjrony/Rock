//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// FinancialGateway Service class
    /// </summary>
    public partial class FinancialGatewayService : Service<FinancialGateway>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialGatewayService"/> class
        /// </summary>
        public FinancialGatewayService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialGatewayService"/> class
        /// </summary>
        public FinancialGatewayService(IRepository<FinancialGateway> repository) : base(repository)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( FinancialGateway item, out string errorMessage )
        {
            errorMessage = string.Empty;
 
            if ( new Service<FinancialTransaction>().Queryable().Any( a => a.GatewayId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialGateway.FriendlyTypeName, FinancialTransaction.FriendlyTypeName );
                return false;
            }  
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static class FinancialGatewayExtensionMethods
    {
        /// <summary>
        /// Clones this FinancialGateway object to a new FinancialGateway object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static FinancialGateway Clone( this FinancialGateway source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as FinancialGateway;
            }
            else
            {
                var target = new FinancialGateway();
                target.Name = source.Name;
                target.Description = source.Description;
                target.Id = source.Id;
                target.Guid = source.Guid;

            
                return target;
            }
        }
    }
}
