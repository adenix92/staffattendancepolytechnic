﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zkemkeeper;

namespace ZKTEchoTest
{
  public  class GaposaZkt : IZKEM
    {
      CZKEM objCZKEM=new CZKEM();
      public bool Status = false;
      public string SerialNumber;
        public bool Connect_Net(String IPAdd, int Port) {
            if (objCZKEM.Connect_Net(IPAdd, Port))
            {
                objCZKEM.GetSerialNumber(1, out SerialNumber);
                objCZKEM.OnConnected += zktConnected;
                Status = true;

            }
            return Status;
        }

        private void zktConnected()
        {
            //string sn;
            //cfData.serialNumber = sn;
        }


        public bool ACUnlock(int dwMachineNumber, int Delay)
        {
            throw new NotImplementedException();
        }

        public int AccGroup
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int BASE64
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool BackupData(string DataFile)
        {
            return objCZKEM.BackupData(DataFile);
        }

        public int BatchDataMode
        {
            get
            {
                return objCZKEM.BatchDataMode;
            }
            set
            {
                objCZKEM.BatchDataMode=value;
            }
        }

        public bool BatchUpdate(int dwMachineNumber)
        {
            return objCZKEM.BatchUpdate(dwMachineNumber);
        }

        public bool Beep(int DelayMS)
        {
           return objCZKEM.Beep(DelayMS);
        }

        public bool BeginBatchUpdate(int dwMachineNumber, int UpdateFlag)
        {
           return objCZKEM.BeginBatchUpdate(dwMachineNumber, UpdateFlag);
        }

        public bool CancelBatchUpdate(int dwMachineNumber)
        {
            return objCZKEM.CancelBatchUpdate(dwMachineNumber);
        }

        public void CancelByUser()
        {
            objCZKEM.CancelByUser();
        }

        public bool CancelOperation()
        {
            return objCZKEM.CancelOperation();
        }

        public bool CaptureImage(bool FullImage, ref int Width, ref int Height, ref byte Image, string ImageFile)
        {
            throw new NotImplementedException();
        }

        public bool ClearAdministrators(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ClearData(int dwMachineNumber, int DataFlag)
        {
            throw new NotImplementedException();
        }

        public bool ClearDataEx(int dwMachineNumber, string TableName)
        {
            throw new NotImplementedException();
        }

        public bool ClearGLog(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ClearKeeperData(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ClearLCD()
        {
            throw new NotImplementedException();
        }

        public bool ClearPhotoByTime(int dwMachineNumber, int iFlag, string sTime, string eTime)
        {
            throw new NotImplementedException();
        }

        public bool ClearSLog(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ClearSMS(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ClearUserSMS(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ClearWorkCode()
        {
            throw new NotImplementedException();
        }

        public bool CloseAlarm(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public int CommPort
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Connect_Com(int ComPort, int MachineNumber, int BaudRate)
        {
            throw new NotImplementedException();
        }

        public bool Connect_Modem(int ComPort, int MachineNumber, int BaudRate, string Telephone)
        {
            throw new NotImplementedException();
        }

        public bool Connect_P4P(string uid)
        {
            throw new NotImplementedException();
        }

        public bool Connect_USB(int MachineNumber)
        {
            throw new NotImplementedException();
        }

        public int ConvertBIG5
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void ConvertPassword(int dwSrcPSW, ref int dwDestPSW, int dwLength)
        {
            throw new NotImplementedException();
        }

        public bool DelCustomizeAttState(int dwMachineNumber, int StateID)
        {
            throw new NotImplementedException();
        }

        public bool DelCustomizeVoice(int dwMachineNumber, int VoiceID)
        {
            throw new NotImplementedException();
        }

        public bool DelUserFace(int dwMachineNumber, string dwEnrollNumber, int dwFaceIndex)
        {
            throw new NotImplementedException();
        }

        public bool DelUserIDCardInfo(int dwMachineNumber, string strEnrollNumber)
        {
            throw new NotImplementedException();
        }

        public bool DelUserTmp(int dwMachineNumber, int dwEnrollNumber, int dwFingerIndex)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAttlogBetweenTheDate(int dwMachineNumber, string sTime, string eTime)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAttlogByTime(int dwMachineNumber, string sTime)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEnrollData(int dwMachineNumber, int dwEnrollNumber, int dwEMachineNumber, int dwBackupNumber)
        {
            throw new NotImplementedException();
        }

        public bool DeletePermOfAppFun(int dwMachineNumber, int Permission, string AppName, string FunName)
        {
            throw new NotImplementedException();
        }

        public bool DeletePicture(int dwMachineNumber, string FileName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSMS(int dwMachineNumber, int ID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserInfoEx(int dwMachineNumber, int dwEnrollNumber)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserPhoto(int dwMachineNumber, string FileName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserSMS(int dwMachineNumber, int dwEnrollNumber, int SMSID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWorkCode(int WorkCodeID)
        {
            throw new NotImplementedException();
        }

        public bool DisableDeviceWithTimeOut(int dwMachineNumber, int TimeOutSec)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public bool DownloadPicture(int dwMachineNumber, string FileName, string FilePath)
        {
            throw new NotImplementedException();
        }

        public bool DownloadUserPhoto(int dwMachineNumber, string FileName, string FilePath)
        {
            throw new NotImplementedException();
        }

        public bool EmptyCard(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool EnableClock(int Enabled)
        {
            throw new NotImplementedException();
        }

        public bool EnableCustomizeAttState(int dwMachineNumber, int StateID, int Enable)
        {
            throw new NotImplementedException();
        }

        public bool EnableCustomizeVoice(int dwMachineNumber, int VoiceID, int Enable)
        {
            throw new NotImplementedException();
        }

        public bool EnableDevice(int dwMachineNumber, bool bFlag)
        {
            throw new NotImplementedException();
        }

        public bool EnableUser(int dwMachineNumber, int dwEnrollNumber, int dwEMachineNumber, int dwBackupNumber, bool bFlag)
        {
            throw new NotImplementedException();
        }

        public bool FPTempConvert(ref byte TmpData1, ref byte TmpData2, ref int Size)
        {
            throw new NotImplementedException();
        }

        public bool FPTempConvertNew(ref byte TmpData1, ref byte TmpData2, ref int Size)
        {
            throw new NotImplementedException();
        }

        public bool FPTempConvertNewStr(string TmpData1, ref string TmpData2, ref int Size)
        {
            throw new NotImplementedException();
        }

        public bool FPTempConvertStr(string TmpData1, ref string TmpData2, ref int Size)
        {
            throw new NotImplementedException();
        }

        public bool GetACFun(ref int ACFun)
        {
            throw new NotImplementedException();
        }

        public bool GetAllAppFun(int dwMachineNumber, out string AppName, out string FunofAppName)
        {
            throw new NotImplementedException();
        }

        public bool GetAllGLogData(int dwMachineNumber, ref int dwTMachineNumber, ref int dwEnrollNumber, ref int dwEMachineNumber, ref int dwVerifyMode, ref int dwInOutMode, ref int dwYear, ref int dwMonth, ref int dwDay, ref int dwHour, ref int dwMinute)
        {
            return objCZKEM.GetAllGLogData(dwMachineNumber, ref dwTMachineNumber, ref dwEnrollNumber, ref dwEMachineNumber, ref dwVerifyMode, ref dwInOutMode, ref dwYear, ref dwMonth, ref dwDay, ref dwHour, ref dwMinute);
        }

        public bool GetAllRole(int dwMachineNumber, out string RoleName)
        {
            return objCZKEM.GetAllRole(dwMachineNumber, out RoleName);
        }

        public bool GetAllSFIDName(int dwMachineNumber, out string ShortkeyIDName, int BufferSize1, out string FunctionIDName, int BufferSize2)
        {
            throw new NotImplementedException();
        }

        public bool GetAllSLogData(int dwMachineNumber, ref int dwTMachineNumber, ref int dwSEnrollNumber, ref int Params4, ref int Params1, ref int Params2, ref int dwManipulation, ref int Params3, ref int dwYear, ref int dwMonth, ref int dwDay, ref int dwHour, ref int dwMinute)
        {
            throw new NotImplementedException();
        }

        public bool GetAllUserID(int dwMachineNumber, ref int dwEnrollNumber, ref int dwEMachineNumber, ref int dwBackupNumber, ref int dwMachinePrivilege, ref int dwEnable)
        {
            return objCZKEM.GetAllUserID(dwMachineNumber, dwEnrollNumber, dwEnrollNumber, dwBackupNumber, dwMachinePrivilege, dwEnable);
        }

        public bool GetAllUserInfo(int dwMachineNumber, ref int dwEnrollNumber, ref string Name, ref string Password, ref int Privilege, ref bool Enabled)
        {
            return objCZKEM.GetAllUserInfo(dwMachineNumber, dwEnrollNumber, Name, Password, Privilege, Enabled);
        }

        public bool GetAllUserPhoto(int dwMachineNumber, string dlDir)
        {
            return objCZKEM.GetAllUserPhoto(dwMachineNumber, dlDir);
        }

        public bool GetAppOfRole(int dwMachineNumber, int Permission, out string AppName)
        {
          return objCZKEM.GetAppOfRole(dwMachineNumber, Permission, out AppName);
        }

        public int GetBackupNumber(int dwMachineNumber)
        {
            return objCZKEM.GetBackupNumber(dwMachineNumber);
        }

        public bool GetBellSchDataEx(int dwMachineNumber, int weekDay, int Index, out int Enable, out int Hour, out int min, out int voice, out int way, out int InerBellDelay, out int ExtBellDelay)
        {
           return objCZKEM.GetBellSchDataEx(dwMachineNumber, weekDay, Index, out Enable, out Hour, out min, out voice, out way, out InerBellDelay, out ExtBellDelay);
        }

        public bool GetCardFun(int dwMachineNumber, ref int CardFun)
        {
            return objCZKEM.GetCardFun(dwMachineNumber, CardFun);
        }

        public void GetConnectStatus(ref int dwErrorCode)
        {
            objCZKEM.GetConnectStatus(dwErrorCode);
        }

        public bool GetDataFile(int dwMachineNumber, int DataFlag, string FileName)
        {
            return objCZKEM.GetDataFile(dwMachineNumber, DataFlag, FileName);
        }

        public bool GetDataFileEx(int dwMachineNumber, string SourceFileName, string DestFileName)
        {
            return objCZKEM.GetDataFileEx(dwMachineNumber, SourceFileName, DestFileName);
        }

        public bool GetDayBellSchCount(int dwMachineNumber, out int DayBellCnt)
        {
            return objCZKEM.GetDayBellSchCount(dwMachineNumber, out DayBellCnt);
        }

        public bool GetDaylight(int dwMachineNumber, ref int Support, ref string BeginTime, ref string EndTime)
        {
            return objCZKEM.GetDaylight(dwMachineNumber, Support, BeginTime, EndTime);
        }

        public bool GetDeviceFirmwareVersion(int dwMachineNumber, ref string strVersion)
        {
           return objCZKEM.GetDeviceFirmwareVersion(dwMachineNumber, strVersion);
        }

        public bool GetDeviceIP(int dwMachineNumber, ref string IPAddr)
        {
            return objCZKEM.GetDeviceIP(dwMachineNumber, ref IPAddr);
        }

        public bool GetDeviceInfo(int dwMachineNumber, int dwInfo, ref int dwValue)
        {
            return objCZKEM.GetDeviceInfo(dwMachineNumber, dwInfo, dwValue);
        }

        public bool GetDeviceMAC(int dwMachineNumber, ref string sMAC)
        {
            return objCZKEM.GetDeviceMAC(dwMachineNumber, sMAC);
        }

        public bool GetDeviceStatus(int dwMachineNumber, int dwStatus, ref int dwValue)
        {
            return objCZKEM.GetDeviceStatus(dwMachineNumber, dwStatus, dwValue);
        }

        public int GetDeviceStatusEx(int dwMachineNumber)
        {
            return objCZKEM.GetDeviceStatusEx(dwMachineNumber);
        }

        public bool GetDeviceStrInfo(int dwMachineNumber, int dwInfo, out string Value)
        {
            return objCZKEM.GetDeviceStrInfo(dwMachineNumber, dwInfo, out Value);
        }

        public bool GetDeviceTime(int dwMachineNumber, ref int dwYear, ref int dwMonth, ref int dwDay, ref int dwHour, ref int dwMinute, ref int dwSecond)
        {
            return objCZKEM.GetDeviceTime(dwMachineNumber, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond);
        }

        public bool GetDoorState(int MachineNumber, ref int State)
        {
            return objCZKEM.GetDoorState(MachineNumber, State);
        }

        public bool GetEachBellInfo(int dwMachineNumber, out int weekDay, out int Index, out int Enable, out int Hour, out int min, out int voice, out int way, out int InerBellDelay, out int ExtBellDelay)
        {
            throw new NotImplementedException();
        }

        public bool GetEnrollData(int dwMachineNumber, int dwEnrollNumber, int dwEMachineNumber, int dwBackupNumber, ref int dwMachinePrivilege, ref int dwEnrollData, ref int dwPassWord)
        {
            throw new NotImplementedException();
        }

        public bool GetEnrollDataStr(int dwMachineNumber, int dwEnrollNumber, int dwEMachineNumber, int dwBackupNumber, ref int dwMachinePrivilege, ref string dwEnrollData, ref int dwPassWord)
        {
            throw new NotImplementedException();
        }

        public int GetFPTempLength(ref byte dwEnrollData)
        {
            throw new NotImplementedException();
        }

        public int GetFPTempLengthStr(string dwEnrollData)
        {
            throw new NotImplementedException();
        }

        public bool GetFirmwareVersion(int dwMachineNumber, ref string strVersion)
        {
            throw new NotImplementedException();
        }

        public bool GetFunOfRole(int dwMachineNumber, int Permission, out string FunName)
        {
            throw new NotImplementedException();
        }

        public bool GetGeneralExtLogData(int dwMachineNumber, ref int dwEnrollNumber, ref int dwVerifyMode, ref int dwInOutMode, ref int dwYear, ref int dwMonth, ref int dwDay, ref int dwHour, ref int dwMinute, ref int dwSecond, ref int dwWorkCode, ref int dwReserved)
        {
            throw new NotImplementedException();
        }

        public bool GetGeneralLogData(int dwMachineNumber, ref int dwTMachineNumber, ref int dwEnrollNumber, ref int dwEMachineNumber, ref int dwVerifyMode, ref int dwInOutMode, ref int dwYear, ref int dwMonth, ref int dwDay, ref int dwHour, ref int dwMinute)
        {
            throw new NotImplementedException();
        }

        public bool GetGeneralLogDataStr(int dwMachineNumber, ref int dwEnrollNumber, ref int dwVerifyMode, ref int dwInOutMode, ref string TimeStr)
        {
            throw new NotImplementedException();
        }

        public bool GetGroupTZStr(int dwMachineNumber, int GroupIndex, ref string TZs)
        {
            throw new NotImplementedException();
        }

        public bool GetGroupTZs(int dwMachineNumber, int GroupIndex, ref int TZs)
        {
            throw new NotImplementedException();
        }

        public bool GetHIDEventCardNumAsStr(out string strHIDEventCardNum)
        {
            throw new NotImplementedException();
        }

        public bool GetHoliday(int dwMachineNumber, ref string Holiday)
        {
            throw new NotImplementedException();
        }

        public void GetLastError(ref int dwErrorCode)
        {
            throw new NotImplementedException();
        }

        public bool GetMaxBellIDInBellSchData(int dwMachineNumber, out int MaxBellID)
        {
            throw new NotImplementedException();
        }

        public bool GetPIN2(int UserID, ref int PIN2)
        {
            throw new NotImplementedException();
        }

        public bool GetPhotoByName(int dwMachineNumber, string PhotoName, out byte PhotoData, out int PhotoLength)
        {
            throw new NotImplementedException();
        }

        public bool GetPhotoByNameToFile(int dwMachineNumber, string PhotoName, string LocalFileName)
        {
            throw new NotImplementedException();
        }

        public bool GetPhotoCount(int dwMachineNumber, out int count, int iFlag)
        {
            throw new NotImplementedException();
        }

        public bool GetPhotoNamesByTime(int dwMachineNumber, int iFlag, string sTime, string eTime, out string AllPhotoName)
        {
            throw new NotImplementedException();
        }

        public bool GetPlatform(int dwMachineNumber, ref string Platform)
        {
            throw new NotImplementedException();
        }

        public bool GetProductCode(int dwMachineNumber, out string lpszProductCode)
        {
            return objCZKEM.GetProductCode(dwMachineNumber, out lpszProductCode);
        }

        public bool GetRTLog(int dwMachineNumber)
        {
            return objCZKEM.GetRTLog(dwMachineNumber);
        }

        public bool GetSDKVersion(ref string strVersion)
        {
            return objCZKEM.GetSDKVersion(ref strVersion);
        }

        public bool GetSMS(int dwMachineNumber, int ID, ref int Tag, ref int ValidMinutes, ref string StartTime, ref string Content)
        {
           return objCZKEM.GetSMS(dwMachineNumber, ID, ref Tag, ref ValidMinutes, ref StartTime, ref Content);
        }

        public bool GetSensorSN(int dwMachineNumber, ref string SensorSN)
        {
            return objCZKEM.GetSensorSN(dwMachineNumber, ref SensorSN);
        }

        public bool GetSerialNumber(int dwMachineNumber, out string dwSerialNumber)
        {
            return objCZKEM.GetSerialNumber(dwMachineNumber, out dwSerialNumber);
        }

        public bool GetShortkey(int dwMachineNumber, int ShortKeyID, ref string ShortKeyName, ref string FunctionName, ref int ShortKeyFun, ref int StateCode, ref string StateName, ref string Description, ref int AutoChange, ref string AutoChangeTime)
        {
            throw new NotImplementedException();
        }

        public bool GetStrCardNumber(out string ACardNumber)
        {
            throw new NotImplementedException();
        }

        public bool GetSuperLogData(int dwMachineNumber, ref int dwTMachineNumber, ref int dwSEnrollNumber, ref int Params4, ref int Params1, ref int Params2, ref int dwManipulation, ref int Params3, ref int dwYear, ref int dwMonth, ref int dwDay, ref int dwHour, ref int dwMinute)
        {
            throw new NotImplementedException();
        }

        public bool GetSuperLogData2(int dwMachineNumber, ref int dwTMachineNumber, ref int dwSEnrollNumber, ref int Params4, ref int Params1, ref int Params2, ref int dwManipulation, ref int Params3, ref int dwYear, ref int dwMonth, ref int dwDay, ref int dwHour, ref int dwMinute, ref int dwSecs)
        {
            throw new NotImplementedException();
        }

        public bool GetSuperLogDataEx(int dwMachineNumber, ref string EnrollNumber, ref int Params4, ref int Params1, ref int Params2, ref int dwManipulation, ref int Params3, ref int dwYear, ref int dwMonth, ref int dwDay, ref int dwHour, ref int dwMinute, ref int dwSecond)
        {
            throw new NotImplementedException();
        }

        public bool GetSysOption(int dwMachineNumber, string Option, out string Value)
        {
            throw new NotImplementedException();
        }

        public bool GetTZInfo(int dwMachineNumber, int TZIndex, ref string TZ)
        {
            throw new NotImplementedException();
        }

        public bool GetUnlockGroups(int dwMachineNumber, ref string Grps)
        {
            throw new NotImplementedException();
        }

        public bool GetUserFace(int dwMachineNumber, string dwEnrollNumber, int dwFaceIndex, ref byte TmpData, ref int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool GetUserFaceStr(int dwMachineNumber, string dwEnrollNumber, int dwFaceIndex, ref string TmpData, ref int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool GetUserGroup(int dwMachineNumber, int dwEnrollNumber, ref int UserGrp)
        {
            throw new NotImplementedException();
        }

        public bool GetUserIDByPIN2(int PIN2, ref int UserID)
        {
            throw new NotImplementedException();
        }

        public bool GetUserIDCardInfo(int dwMachineNumber, string strEnrollNumber, out byte IDCardData, ref int DataLen)
        {
            throw new NotImplementedException();
        }

        public bool GetUserInfo(int dwMachineNumber, int dwEnrollNumber, ref string Name, ref string Password, ref int Privilege, ref bool Enabled)
        {
            throw new NotImplementedException();
        }

        public bool GetUserInfoByCard(int dwMachineNumber, ref string Name, ref string Password, ref int Privilege, ref bool Enabled)
        {
            throw new NotImplementedException();
        }

        public bool GetUserInfoByPIN2(int dwMachineNumber, ref string Name, ref string Password, ref int Privilege, ref bool Enabled)
        {
            throw new NotImplementedException();
        }

        public bool GetUserInfoEx(int dwMachineNumber, int dwEnrollNumber, out int VerifyStyle, out byte Reserved)
        {
            throw new NotImplementedException();
        }

        public bool GetUserTZStr(int dwMachineNumber, int dwEnrollNumber, ref string TZs)
        {
            throw new NotImplementedException();
        }

        public bool GetUserTZs(int dwMachineNumber, int dwEnrollNumber, ref int TZs)
        {
            throw new NotImplementedException();
        }

        public bool GetUserTmp(int dwMachineNumber, int dwEnrollNumber, int dwFingerIndex, ref byte TmpData, ref int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool GetUserTmpEx(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex, out int Flag, out byte TmpData, out int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool GetUserTmpExStr(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex, out int Flag, out string TmpData, out int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool GetUserTmpStr(int dwMachineNumber, int dwEnrollNumber, int dwFingerIndex, ref string TmpData, ref int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool GetUserValidDate(int dwMachineNumber, string UserID, out int Expires, out int ValidCount, out string StartDate, out string EndDate)
        {
            throw new NotImplementedException();
        }

        public bool GetUserValidDateBatch(int dwMachineNumber, out string Buffer, int BufferSize)
        {
            throw new NotImplementedException();
        }

        public bool GetUserVerifyStyle(int dwMachineNumber, string dwEnrollNumber, out int VerifyStyle, out byte Reserved)
        {
            throw new NotImplementedException();
        }

        public bool GetUserVerifyStyleBatch(int dwMachineNumber, out string Buffer, int BufferSize, out byte Reserved)
        {
            throw new NotImplementedException();
        }

        public bool GetVendor(ref string strVendor)
        {
            throw new NotImplementedException();
        }

        public bool GetWiegandFmt(int dwMachineNumber, ref string sWiegandFmt)
        {
            throw new NotImplementedException();
        }

        public bool GetWorkCode(int WorkCodeID, out int AWorkCode)
        {
            throw new NotImplementedException();
        }

        public bool IsNewFirmwareMachine(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsTFTMachine(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsUserDefRoleEnable(int dwMachineNumber, int Permission, out bool Enable)
        {
            throw new NotImplementedException();
        }

        public int MachineNumber
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int MaxP4PConnect
        {
            get { throw new NotImplementedException(); }
        }

        public bool MergeTemplate(IntPtr Templates, int FingerCount, ref byte TemplateDest, ref int FingerSize)
        {
            throw new NotImplementedException();
        }

        public bool ModifyPrivilege(int dwMachineNumber, int dwEnrollNumber, int dwEMachineNumber, int dwBackupNumber, int dwMachinePrivilege)
        {
            throw new NotImplementedException();
        }

        public uint PIN2
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int PINWidth
        {
            get { throw new NotImplementedException(); }
        }

        public bool PlayVoice(int Position, int Length)
        {
            throw new NotImplementedException();
        }

        public bool PlayVoiceByIndex(int Index)
        {
            throw new NotImplementedException();
        }

        public bool PowerOffDevice(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public void PowerOnAllDevice()
        {
            throw new NotImplementedException();
        }

        public int PullMode
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool QueryState(ref int State)
        {
            throw new NotImplementedException();
        }

        public bool ReadAOptions(string AOption, out string AValue)
        {
            throw new NotImplementedException();
        }

        public bool ReadAllBellSchData(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ReadAllGLogData(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ReadAllSLogData(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ReadAllTemplate(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ReadAllUserID(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ReadAttRule(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ReadCustData(int dwMachineNumber, ref string CustData)
        {
            throw new NotImplementedException();
        }

        public bool ReadDPTInfo(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool ReadFile(int dwMachineNumber, string FileName, string FilePath)
        {
            throw new NotImplementedException();
        }

        public bool ReadGeneralLogData(int dwMachineNumber)
        {
           return objCZKEM.ReadGeneralLogData(dwMachineNumber);
        }

        public bool ReadLastestLogData(int dwMachineNumber, int NewLog, int dwYear, int dwMonth, int dwDay, int dwHour, int dwMinute, int dwSecond)
        {
            throw new NotImplementedException();
        }

        public bool ReadMark
        {
            get
            {
                return objCZKEM.ReadMark;
            }
            set
            {
                objCZKEM.ReadMark=value;
            }
        }

        public bool ReadNewGLogData(int dwMachineNumber)
        {
            return objCZKEM.ReadNewGLogData(dwMachineNumber);
        }

        public bool ReadRTLog(int dwMachineNumber)
        {
            return objCZKEM.ReadRTLog(dwMachineNumber);
        }

        public bool ReadSuperLogData(int dwMachineNumber)
        {
            return objCZKEM.ReadSuperLogData(dwMachineNumber);
        }

        public bool ReadSuperLogDataEx(int dwMachineNumber, int dwYear_S, int dwMonth_S, int dwDay_S, int dwHour_S, int dwMinute_S, int dwSecond_S, int dwYear_E, int dwMonth_E, int dwDay_E, int dwHour_E, int dwMinute_E, int dwSecond_E, int dwLogIndex)
        {
            return objCZKEM.ReadSuperLogDataEx(dwMachineNumber, dwYear_S, dwMonth_S, dwDay_S, dwHour_S, dwMinute_S, dwSecond_S, dwYear_E, dwMonth_E, dwDay_E, dwHour_E, dwMinute_E, dwSecond_E, dwLogIndex);
        }

        public bool ReadTimeGLogData(int dwMachineNumber, string sTime, string eTime)
        {
            return objCZKEM.ReadTimeGLogData(dwMachineNumber, sTime, eTime);
        }

        public bool ReadTurnInfo(int dwMachineNumber)
        {
            return objCZKEM.ReadTurnInfo(dwMachineNumber);
        }

        public bool ReadUserAllTemplate(int dwMachineNumber, string dwEnrollNumber)
        {
            return objCZKEM.ReadUserAllTemplate(dwMachineNumber, dwEnrollNumber);
        }

        public bool RefreshData(int dwMachineNumber)
        {
            return objCZKEM.RefreshData(dwMachineNumber);
        }

        public bool RegEvent(int dwMachineNumber, int EventMask)
        {
            return objCZKEM.RegEvent(dwMachineNumber, EventMask);
        }

        public bool RestartDevice(int dwMachineNumber)
        {
            return objCZKEM.RestartDevice(dwMachineNumber);
        }

        public bool RestoreData(string DataFile)
        {
            return objCZKEM.RestoreData(DataFile);
        }

        public int SSRPin
        {
            get { return objCZKEM.SSRPin; }
        }

        public bool SSR_ClearWorkCode()
        {
            return objCZKEM.SSR_ClearWorkCode();
        }

        public bool SSR_DelUserTmp(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex)
        {
            return objCZKEM.SSR_DelUserTmp(dwMachineNumber, dwEnrollNumber, dwFingerIndex);
        }

        public bool SSR_DelUserTmpExt(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex)
        {
            throw new NotImplementedException();
        }

        public bool SSR_DeleteDeviceData(int dwMachineNumber, string TableName, string Datas, string Options)
        {
            throw new NotImplementedException();
        }

        public bool SSR_DeleteEnrollData(int dwMachineNumber, string dwEnrollNumber, int dwBackupNumber)
        {
            throw new NotImplementedException();
        }

        public bool SSR_DeleteEnrollDataExt(int dwMachineNumber, string dwEnrollNumber, int dwBackupNumber)
        {
            throw new NotImplementedException();
        }

        public bool SSR_DeleteUserSMS(int dwMachineNumber, string dwEnrollNumber, int SMSID)
        {
            throw new NotImplementedException();
        }

        public bool SSR_DeleteWorkCode(int PIN)
        {
            throw new NotImplementedException();
        }

        public bool SSR_DeleteWorkCodeEx(int dwMachineNumber, string WorkCodeNum)
        {
            throw new NotImplementedException();
        }

        public bool SSR_EnableUser(int dwMachineNumber, string dwEnrollNumber, bool bFlag)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetAllUserInfo(int dwMachineNumber, out string dwEnrollNumber, out string Name, out string Password, out int Privilege, out bool Enabled)
        {
            return objCZKEM.SSR_GetAllUserInfo(dwMachineNumber, out dwEnrollNumber, out Name, out Password, out Privilege, out Enabled);
        }

        public bool SSR_GetDeviceData(int dwMachineNumber, out string Buffer, int BufferSize, string TableName, string FiledNames, string Filter, string Options)
        {
            throw new NotImplementedException();
        }

        public int SSR_GetDeviceDataCount(string TableName, string Filter, string Options)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetGeneralLogData(int dwMachineNumber, out string dwEnrollNumber, out int dwVerifyMode, out int dwInOutMode, out int dwYear, out int dwMonth, out int dwDay, out int dwHour, out int dwMinute, out int dwSecond, ref int dwWorkCode)
        {
            return objCZKEM.SSR_GetGeneralLogData(dwMachineNumber, out dwEnrollNumber,out dwVerifyMode, out dwInOutMode, out dwYear, out dwMonth, out dwDay, out dwHour, out dwMinute, out dwSecond, ref dwWorkCode);
        }

        public bool SSR_GetGeneralLogDataEx(int dwMachineNumber, out string dwEnrollNumber, out int dwVerifyMode, out int dwInOutMode, out int dwYear, out int dwMonth, out int dwDay, out int dwHour, out int dwMinute, out int dwSecond, out string dwWorkCode)
        {
            return objCZKEM.SSR_GetGeneralLogDataEx(dwMachineNumber, out dwEnrollNumber, out dwVerifyMode, out dwInOutMode, out dwYear, out dwMonth, out dwDay, out dwHour, out dwMinute, out dwSecond, out dwWorkCode);
        }

        public bool SSR_GetGroupTZ(int dwMachineNumber, int GroupNo, ref int Tz1, ref int Tz2, ref int Tz3, ref int VaildHoliday, ref int VerifyStyle)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetHoliday(int dwMachineNumber, int HolidayID, ref int BeginMonth, ref int BeginDay, ref int EndMonth, ref int EndDay, ref int TimeZoneID)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetShortkey(int ShortKeyID, ref int ShortKeyFun, ref int StateCode, ref string StateName, ref int AutoChange, ref string AutoChangeTime)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetSuperLogData(int MachineNumber, out int Number, out string Admin, out string User, out int Manipulation, out string Time, out int Params1, out int Params2, out int Params3)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetUnLockGroup(int dwMachineNumber, int CombNo, ref int Group1, ref int Group2, ref int Group3, ref int Group4, ref int Group5)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetUserInfo(int dwMachineNumber, string dwEnrollNumber, out string Name, out string Password, out int Privilege, out bool Enabled)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetUserTmp(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex, out byte TmpData, out int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetUserTmpStr(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex, out string TmpData, out int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetWorkCode(int AWorkCode, out string Name)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetWorkCodeEx(int dwMachineNumber, string WorkCodeNum, out string Name)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetWorkCodeExBatch(int dwMachineNumber, out string Buffer, int BufferSize)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetWorkCodeExByID(int dwMachineNumber, int WorkCodeID, out string WorkCodeNum, out string Name)
        {
            throw new NotImplementedException();
        }

        public bool SSR_GetWorkCodeIDByName(int dwMachineNumber, string workcodeName, out int WorkCodeID)
        {
            throw new NotImplementedException();
        }

        public bool SSR_OutPutHTMLRep(int dwMachineNumber, string dwEnrollNumber, string AttFile, string UserFile, string DeptFile, string TimeClassFile, string AttruleFile, int BYear, int BMonth, int BDay, int BHour, int BMinute, int BSecond, int EYear, int EMonth, int EDay, int EHour, int EMinute, int ESecond, string TempPath, string OutFileName, int HTMLFlag, int resv1, string resv2)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetDeviceData(int dwMachineNumber, string TableName, string Datas, string Options)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetGroupTZ(int dwMachineNumber, int GroupNo, int Tz1, int Tz2, int Tz3, int VaildHoliday, int VerifyStyle)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetHoliday(int dwMachineNumber, int HolidayID, int BeginMonth, int BeginDay, int EndMonth, int EndDay, int TimeZoneID)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetShortkey(int ShortKeyID, int ShortKeyFun, int StateCode, string StateName, int StateAutoChange, string StateAutoChangeTime)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetUnLockGroup(int dwMachineNumber, int CombNo, int Group1, int Group2, int Group3, int Group4, int Group5)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetUserInfo(int dwMachineNumber, string dwEnrollNumber, string Name, string Password, int Privilege, bool Enabled)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetUserSMS(int dwMachineNumber, string dwEnrollNumber, int SMSID)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetUserTmp(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex, ref byte TmpData)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetUserTmpExt(int dwMachineNumber, int IsDeleted, string dwEnrollNumber, int dwFingerIndex, ref byte TmpData)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetUserTmpStr(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex, string TmpData)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetWorkCode(int AWorkCode, string Name)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetWorkCodeEx(int dwMachineNumber, string WorkCodeNum, string Name)
        {
            throw new NotImplementedException();
        }

        public bool SSR_SetWorkCodeExBatch(int dwMachineNumber, string Datas)
        {
            throw new NotImplementedException();
        }

        public bool SaveTheDataToFile(int dwMachineNumber, string TheFilePath, int FileFlag)
        {
            throw new NotImplementedException();
        }

        public bool SearchDevice(string commType, string address, out string DevBuffer, int DevBufferSize)
        {
            throw new NotImplementedException();
        }

        public bool SendCMDMsg(int dwMachineNumber, int Param1, int Param2)
        {
            throw new NotImplementedException();
        }

        public bool SendFile(int dwMachineNumber, string FileName)
        {
            throw new NotImplementedException();
        }

        public bool SendFileByType(int dwMachineNumber, string FileName, int iType)
        {
            throw new NotImplementedException();
        }

        public bool SendFileEx(int dwMachineNumber, string FileName, string FilePath)
        {
            throw new NotImplementedException();
        }

        public bool SetBellSchDataEx(int dwMachineNumber, int weekDay, int Index, int Enable, int Hour, int min, int voice, int way, int InerBellDelay, int ExtBellDelay)
        {
            throw new NotImplementedException();
        }

        public bool SetCommPassword(int CommKey)
        {
            throw new NotImplementedException();
        }

        public bool SetCommProType(int proType)
        {
            throw new NotImplementedException();
        }

        public bool SetCommuTimeOut(int timeOut)
        {
            throw new NotImplementedException();
        }

        public bool SetCompatOldFirmware(int nCompatOkdFirmware)
        {
            throw new NotImplementedException();
        }

        public bool SetCustomizeAttState(int dwMachineNumber, int StateID, int NewState)
        {
            throw new NotImplementedException();
        }

        public bool SetCustomizeVoice(int dwMachineNumber, int VoiceID, string FileName)
        {
            throw new NotImplementedException();
        }

        public bool SetDaylight(int dwMachineNumber, int Support, string BeginTime, string EndTime)
        {
            throw new NotImplementedException();
        }

        public bool SetDeviceCommPwd(int dwMachineNumber, int CommKey)
        {
            throw new NotImplementedException();
        }

        public bool SetDeviceIP(int dwMachineNumber, string IPAddr)
        {
            throw new NotImplementedException();
        }

        public bool SetDeviceInfo(int dwMachineNumber, int dwInfo, int dwValue)
        {
            throw new NotImplementedException();
        }

        public bool SetDeviceMAC(int dwMachineNumber, string sMAC)
        {
            throw new NotImplementedException();
        }

        public bool SetDeviceTableData(int dwMachineNumber, string TableName, string Datas, string Options, out int count)
        {
            throw new NotImplementedException();
        }

        public bool SetDeviceTime(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool SetDeviceTime2(int dwMachineNumber, int dwYear, int dwMonth, int dwDay, int dwHour, int dwMinute, int dwSecond)
        {
            throw new NotImplementedException();
        }

        public bool SetEnrollData(int dwMachineNumber, int dwEnrollNumber, int dwEMachineNumber, int dwBackupNumber, int dwMachinePrivilege, ref int dwEnrollData, int dwPassWord)
        {
            throw new NotImplementedException();
        }

        public bool SetEnrollDataStr(int dwMachineNumber, int dwEnrollNumber, int dwEMachineNumber, int dwBackupNumber, int dwMachinePrivilege, string dwEnrollData, int dwPassWord)
        {
            throw new NotImplementedException();
        }

        public bool SetEventMode(int nType)
        {
            throw new NotImplementedException();
        }

        public bool SetGroupTZStr(int dwMachineNumber, int GroupIndex, string TZs)
        {
            throw new NotImplementedException();
        }

        public bool SetGroupTZs(int dwMachineNumber, int GroupIndex, ref int TZs)
        {
            throw new NotImplementedException();
        }

        public bool SetHoliday(int dwMachineNumber, string Holiday)
        {
            throw new NotImplementedException();
        }

        public bool SetLanguageByID(int dwMachineNumber, int LanguageID, string Language)
        {
            throw new NotImplementedException();
        }

        public bool SetLastCount(int count)
        {
            throw new NotImplementedException();
        }

        public bool SetManufacturerData(int dwMachineNumber, string Name, string Value)
        {
            throw new NotImplementedException();
        }

        public bool SetOptionCommPwd(int dwMachineNumber, string CommKey)
        {
            throw new NotImplementedException();
        }

        public bool SetPermOfAppFun(int dwMachineNumber, int Permission, string AppName, string FunName)
        {
            throw new NotImplementedException();
        }

        public bool SetSMS(int dwMachineNumber, int ID, int Tag, int ValidMinutes, string StartTime, string Content)
        {
            throw new NotImplementedException();
        }

        public bool SetShortkey(int dwMachineNumber, int ShortKeyID, string ShortKeyName, string FunctionName, int ShortKeyFun, int StateCode, string StateName, string Description, int StateAutoChange, string StateAutoChangeTime)
        {
            throw new NotImplementedException();
        }

        public bool SetStrCardNumber(string ACardNumber)
        {
            throw new NotImplementedException();
        }

        public bool SetSysOption(int dwMachineNumber, string Option, string Value)
        {
            throw new NotImplementedException();
        }

        public bool SetTZInfo(int dwMachineNumber, int TZIndex, string TZ)
        {
            throw new NotImplementedException();
        }

        public bool SetUnlockGroups(int dwMachineNumber, string Grps)
        {
            throw new NotImplementedException();
        }

        public bool SetUserFace(int dwMachineNumber, string dwEnrollNumber, int dwFaceIndex, ref byte TmpData, int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool SetUserFaceStr(int dwMachineNumber, string dwEnrollNumber, int dwFaceIndex, string TmpData, int TmpLength)
        {
            throw new NotImplementedException();
        }

        public bool SetUserGroup(int dwMachineNumber, int dwEnrollNumber, int UserGrp)
        {
            throw new NotImplementedException();
        }

        public bool SetUserIDCardInfo(int dwMachineNumber, string strEnrollNumber, ref byte IDCardData, int DataLen)
        {
            throw new NotImplementedException();
        }

        public bool SetUserInfo(int dwMachineNumber, int dwEnrollNumber, string Name, string Password, int Privilege, bool Enabled)
        {
            throw new NotImplementedException();
        }

        public bool SetUserInfoEx(int dwMachineNumber, int dwEnrollNumber, int VerifyStyle, ref byte Reserved)
        {
            throw new NotImplementedException();
        }

        public bool SetUserSMS(int dwMachineNumber, int dwEnrollNumber, int SMSID)
        {
            throw new NotImplementedException();
        }

        public bool SetUserTZStr(int dwMachineNumber, int dwEnrollNumber, string TZs)
        {
            throw new NotImplementedException();
        }

        public bool SetUserTZs(int dwMachineNumber, int dwEnrollNumber, ref int TZs)
        {
            throw new NotImplementedException();
        }

        public bool SetUserTmp(int dwMachineNumber, int dwEnrollNumber, int dwFingerIndex, ref byte TmpData)
        {
            throw new NotImplementedException();
        }

        public bool SetUserTmpEx(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex, int Flag, ref byte TmpData)
        {
            throw new NotImplementedException();
        }

        public bool SetUserTmpExStr(int dwMachineNumber, string dwEnrollNumber, int dwFingerIndex, int Flag, string TmpData)
        {
            throw new NotImplementedException();
        }

        public bool SetUserTmpStr(int dwMachineNumber, int dwEnrollNumber, int dwFingerIndex, string TmpData)
        {
            throw new NotImplementedException();
        }

        public bool SetUserValidDate(int dwMachineNumber, string UserID, int Expires, int ValidCount, string StartDate, string EndDate)
        {
            throw new NotImplementedException();
        }

        public bool SetUserValidDateBatch(int dwMachineNumber, string Datas)
        {
            throw new NotImplementedException();
        }

        public bool SetUserVerifyStyle(int dwMachineNumber, string dwEnrollNumber, int VerifyStyle, ref byte Reserved)
        {
            throw new NotImplementedException();
        }

        public bool SetUserVerifyStyleBatch(int dwMachineNumber, string Datas, ref byte Reserved)
        {
            throw new NotImplementedException();
        }

        public bool SetWiegandFmt(int dwMachineNumber, string sWiegandFmt)
        {
            throw new NotImplementedException();
        }

        public bool SetWorkCode(int WorkCodeID, int AWorkCode)
        {
            throw new NotImplementedException();
        }

        public bool SplitTemplate(ref byte Template, IntPtr Templates, ref int FingerCount, ref int FingerSize)
        {
            throw new NotImplementedException();
        }

        public bool StartEnroll(int UserID, int FingerID)
        {
            throw new NotImplementedException();
        }

        public bool StartEnrollEx(string UserID, int FingerID, int Flag)
        {
            throw new NotImplementedException();
        }

        public bool StartIdentify()
        {
            throw new NotImplementedException();
        }

        public bool StartVerify(int UserID, int FingerID)
        {
            throw new NotImplementedException();
        }

        public bool TurnOffAlarm(int dwMachineNumber)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFile(string FileName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFirmware(string FirmwareFile)
        {
            throw new NotImplementedException();
        }

        public bool UpdateLogo(int dwMachineNumber, string FileName)
        {
            throw new NotImplementedException();
        }

        public bool UploadPicture(int dwMachineNumber, string FileName, string InDevName)
        {
            throw new NotImplementedException();
        }

        public bool UploadTheme(int dwMachineNumber, string FileName, string InDevName)
        {
            throw new NotImplementedException();
        }

        public bool UploadUserPhoto(int dwMachineNumber, string FileName)
        {
            throw new NotImplementedException();
        }

        public bool UseGroupTimeZone()
        {
            throw new NotImplementedException();
        }

        public bool WriteCard(int dwMachineNumber, int dwEnrollNumber, int dwFingerIndex1, ref byte TmpData1, int dwFingerIndex2, ref byte TmpData2, int dwFingerIndex3, ref byte TmpData3, int dwFingerIndex4, ref byte TmpData4)
        {
            throw new NotImplementedException();
        }

        public bool WriteCustData(int dwMachineNumber, string CustData)
        {
            throw new NotImplementedException();
        }

        public bool WriteLCD(int Row, int Col, string Text)
        {
            throw new NotImplementedException();
        }

        public int get_AccTimeZones(int Index)
        {
            throw new NotImplementedException();
        }

        public int get_CardNumber(int Index)
        {
            throw new NotImplementedException();
        }

        public string get_STR_CardNumber(int Index)
        {
            throw new NotImplementedException();
        }

        public void set_AccTimeZones(int Index, int pVal)
        {
            throw new NotImplementedException();
        }

        public void set_CardNumber(int Index, int pVal)
        {
            throw new NotImplementedException();
        }

        public void set_STR_CardNumber(int Index, string pVal)
        {
            throw new NotImplementedException();
        }
    }
}
