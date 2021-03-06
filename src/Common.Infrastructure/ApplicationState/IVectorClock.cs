﻿// BudgetFirst 
// ©2016 Thomas Mühlgrabner
//
// This source code is dual-licensed under:
//   * Mozilla Public License 2.0 (MPL 2.0) 
//   * GNU General Public License v3.0 (GPLv3)
//
// ==================== Mozilla Public License 2.0 ===================
// This Source Code Form is subject to the terms of the Mozilla Public 
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.
// ================= GNU General Public License v3.0 =================
// This file is part of BudgetFirst.
//
// BudgetFirst is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// BudgetFirst is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with Budget First.  If not, see<http://www.gnu.org/licenses/>.
// ===================================================================

namespace BudgetFirst.Common.Infrastructure.ApplicationState
{
    using BudgetFirst.Common.Infrastructure.Domain.Events;
    using BudgetFirst.Common.Infrastructure.Messaging;

    /// <summary>
    /// Provides access to the current vector clock
    /// </summary>
    public interface IVectorClock
    {
        /// <summary>
        /// Increment the current vector clock
        /// </summary>
        void Increment();

        /// <summary>
        /// Create a copy of this vector clock
        /// </summary>
        /// <returns>A clone of this vector clock</returns>
        IVectorClock Clone();

        /// <summary>
        /// Get the current vector clock
        /// </summary>
        /// <returns>The underlying vector clock (as a copy)</returns>
        VectorClock GetVectorClock();

        /// <summary>
        /// Update the vector clock to a new value
        /// </summary>
        /// <param name="value">New value to set</param>
        void Update(IVectorClock value);
    }
}