﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model
{
    public class RoleAssignment : IEquatable<RoleAssignment>
    {
        /// <summary>
        /// Defines the Role to which the assignment will apply
        /// </summary>
        public String Principal { get; set; }

        /// <summary>
        /// Defines the Role to which the assignment will apply
        /// </summary>
        public String RoleDefinition { get; set; }

        #region Comparison code

        public override int GetHashCode()
        {
            return (String.Format("{0}|{1}|",
                this.Principal,
                this.RoleDefinition
                ).GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RoleAssignment))
            {
                return (false);
            }
            return (Equals((RoleAssignment)obj));
        }

        public bool Equals(RoleAssignment other)
        {
            return (this.Principal == other.Principal &&
                this.RoleDefinition == other.RoleDefinition);
        }

        #endregion
    }
}
