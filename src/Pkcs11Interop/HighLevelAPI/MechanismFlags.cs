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
    /// Flags specifying mechanism capabilities
    /// </summary>
    public class MechanismFlags
    {
        /// <summary>
        /// Bits flags specifying mechanism capabilities
        /// </summary>
        private uint _flags;

        /// <summary>
        /// Bits flags specifying mechanism capabilities
        /// </summary>
        public uint Flags
        {
            get
            {
                return _flags;
            }
        }

        /// <summary>
        /// True if the mechanism is performed by the device; false if the mechanism is performed in software
        /// </summary>
        public bool Hw
        {
            get
            {
                return ((_flags & CKF.CKF_HW) == CKF.CKF_HW);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_EncryptInit
        /// </summary>
        public bool Encrypt
        {
            get
            {
                return ((_flags & CKF.CKF_ENCRYPT) == CKF.CKF_ENCRYPT);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_DecryptInit
        /// </summary>
        public bool Decrypt
        {
            get
            {
                return ((_flags & CKF.CKF_DECRYPT) == CKF.CKF_DECRYPT);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_DigestInit
        /// </summary>
        public bool Digest
        {
            get
            {
                return ((_flags & CKF.CKF_DIGEST) == CKF.CKF_DIGEST);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_SignInit
        /// </summary>
        public bool Sign
        {
            get
            {
                return ((_flags & CKF.CKF_SIGN) == CKF.CKF_SIGN);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_SignRecoverInit
        /// </summary>
        public bool SignRecover
        {
            get
            {
                return ((_flags & CKF.CKF_SIGN_RECOVER) == CKF.CKF_SIGN_RECOVER);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_VerifyInit
        /// </summary>
        public bool Verify
        {
            get
            {
                return ((_flags & CKF.CKF_VERIFY) == CKF.CKF_VERIFY);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_VerifyRecoverInit
        /// </summary>
        public bool VerifyRecover
        {
            get
            {
                return ((_flags & CKF.CKF_VERIFY_RECOVER) == CKF.CKF_VERIFY_RECOVER);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_GenerateKey
        /// </summary>
        public bool Generate
        {
            get
            {
                return ((_flags & CKF.CKF_GENERATE) == CKF.CKF_GENERATE);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_GenerateKeyPair
        /// </summary>
        public bool GenerateKeyPair
        {
            get
            {
                return ((_flags & CKF.CKF_GENERATE_KEY_PAIR) == CKF.CKF_GENERATE_KEY_PAIR);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_WrapKey
        /// </summary>
        public bool Wrap
        {
            get
            {
                return ((_flags & CKF.CKF_WRAP) == CKF.CKF_WRAP);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_UnwrapKey
        /// </summary>
        public bool Unwrap
        {
            get
            {
                return ((_flags & CKF.CKF_UNWRAP) == CKF.CKF_UNWRAP);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with C_DeriveKey
        /// </summary>
        public bool Derive
        {
            get
            {
                return ((_flags & CKF.CKF_DERIVE) == CKF.CKF_DERIVE);
            }
        }

        /// <summary>
        /// True if there is an extension to the flags; false if no extensions.
        /// </summary>
        public bool Extension
        {
            get
            {
                return ((_flags & CKF.CKF_EXTENSION) == CKF.CKF_EXTENSION);
            }
        }

        #region Elliptic Curve

        /// <summary>
        /// True if the mechanism can be used with EC domain parameters over Fp
        /// </summary>
        public bool EcFp
        {
            get
            {
                return ((_flags & CKF.CKF_EC_F_P) == CKF.CKF_EC_F_P);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with EC domain parameters over F2m
        /// </summary>
        public bool EcF2m
        {
            get
            {
                return ((_flags & CKF.CKF_EC_F_2M) == CKF.CKF_EC_F_2M);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with EC domain parameters of the choice ecParameters
        /// </summary>
        public bool EcEcParameters
        {
            get
            {
                return ((_flags & CKF.CKF_EC_ECPARAMETERS) == CKF.CKF_EC_ECPARAMETERS);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with EC domain parameters of the choice namedCurve
        /// </summary>
        public bool EcNamedCurve
        {
            get
            {
                return ((_flags & CKF.CKF_EC_NAMEDCURVE) == CKF.CKF_EC_NAMEDCURVE);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with elliptic curve point uncompressed
        /// </summary>
        public bool EcUncompress
        {
            get
            {
                return ((_flags & CKF.CKF_EC_UNCOMPRESS) == CKF.CKF_EC_UNCOMPRESS);
            }
        }

        /// <summary>
        /// True if the mechanism can be used with elliptic curve point compressed
        /// </summary>
        public bool EcCompress
        {
            get
            {
                return ((_flags & CKF.CKF_EC_COMPRESS) == CKF.CKF_EC_COMPRESS);
            }
        }

        #endregion

        /// <summary>
        /// Initializes new instance of MechanismFlags class
        /// </summary>
        /// <param name="flags">Bits flags specifying mechanism capabilities</param>
        internal MechanismFlags(uint flags)
        {
            _flags = flags;
        }
    }
}
