/*************************************************************************
 *  Copyright (C) 2024 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  Status.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  1.0.0
 *  Date         :  2024/2/19
 *  Description  :  Initial development version.
 *************************************************************************/

namespace MGS.FSM
{
    /// <summary>
    /// Represents the status of an FSM.
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// None status.
        /// </summary>
        None = 0,

        /// <summary>
        /// Preparing status.
        /// </summary>
        Preparing = 1,

        /// <summary>
        /// Prepared status.
        /// </summary>
        Prepared = 2,

        /// <summary>
        /// Working status.
        /// </summary>
        Working = 3,

        /// <summary>
        /// Completed status.
        /// </summary>
        Completed = 4
    }
}