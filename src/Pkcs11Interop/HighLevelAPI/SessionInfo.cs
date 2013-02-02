﻿/*
 *  Pkcs11Interop - Open-source .NET wrapper for unmanaged PKCS#11 libraries
 *  Copyright (C) 2012 Jaroslav Imrich <jimrich(at)jimrich(dot)sk>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License version 3
 *  as published by the Free Software Foundation.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 *  If this license does not suit your needs you can purchase a commercial
 *  license from Pkcs11Interop author.
 */

using Net.Pkcs11Interop.Common;

namespace Net.Pkcs11Interop.HighLevelAPI
{
    /// <summary>
    /// Information about a session
    /// </summary>
    public class SessionInfo
    {   
        /// <summary>
        /// PKCS#11 handle of session
        /// </summary>
        private uint _sessionId = CK.CK_INVALID_HANDLE;

        /// <summary>
        /// PKCS#11 handle of session
        /// </summary>
        public uint SessionId
        {
            get
            {
                return _sessionId;
            }
        }

        /// <summary>
        /// PKCS#11 handle of slot that interfaces with the token
        /// </summary>
        private uint _slotId = CK.CK_INVALID_HANDLE;

        /// <summary>
        /// PKCS#11 handle of slot that interfaces with the token
        /// </summary>
        public uint SlotId
        {
            get
            {
                return _slotId;
            }
        }

        /// <summary>
        /// The state of the session
        /// </summary>
        private CKS _state = 0;

        /// <summary>
        /// The state of the session
        /// </summary>
        public CKS State
        {
            get
            {
                return _state;
            }
        }

        /// <summary>
        /// Flags that define the type of session
        /// </summary>
        private SessionFlags _sessionFlags = null;

        /// <summary>
        /// Flags that define the type of session
        /// </summary>
        public SessionFlags SessionFlags
        {
            get
            {
                return _sessionFlags;
            }
        }

        /// <summary>
        /// An error code defined by the cryptographic device used for errors not covered by Cryptoki
        /// </summary>
        private uint _deviceError = 0;

        /// <summary>
        /// An error code defined by the cryptographic device used for errors not covered by Cryptoki
        /// </summary>
        public uint DeviceError
        {
            get
            {
                return _deviceError;
            }
        }

        /// <summary>
        /// Converts low level CK_SESSION_INFO structure to high level SessionInfo class
        /// </summary>
        /// <param name="sessionId">PKCS#11 handle of session</param>
        /// <param name="ck_slot_info">Low level CK_SESSION_INFO structure</param>
        internal SessionInfo(uint sessionId, LowLevelAPI.CK_SESSION_INFO ck_session_info)
        {
            _sessionId = sessionId;
            _slotId = ck_session_info.SlotId;
            _state = (CKS)ck_session_info.State;
            _sessionFlags = new SessionFlags(ck_session_info.Flags);
            _deviceError = ck_session_info.DeviceError;
        }
    }
}
