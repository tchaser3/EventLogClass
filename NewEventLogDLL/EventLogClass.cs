/* Title:           New Event Log DLL
 * Date:            4-24-17
 * Author:          Terry Holmes
 * 
 * Description:     This Class is for the new Event Log */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace NewEventLogDLL
{
    public class EventLogClass
    {
        //setting up the data
        EventLogDataSet aEventLogDataSet;
        EventLogDataSetTableAdapters.eventlogTableAdapter aEventLogTableAdapter;

        InsertEventLogEntry aInsertEventLogEntry;
        InsertEventLogEntryTableAdapters.QueriesTableAdapter aInsertEventLogTableAdapter;

        FindEventLogByDateRangeDataSet aFindEventLogByDateRangeDataSet;
        FindEventLogByDateRangeDataSetTableAdapters.FindEventLogEntriesByDateRangeTableAdapter aFindEventLogByDateRangeTableAdapter;

        ServerEventLogDataSet aServerEventLogDataSet;
        ServerEventLogDataSetTableAdapters.servereventlogTableAdapter aServerEventLogTableAdapter;

        InsertServerEventLogEntryTableAdapters.QueriesTableAdapter aInsertServerEventLogEntryTableAdapter;

        FindServerEventLogByTransactionDateDataSet aFindServerEventLogByTransactionDateDataSet;
        FindServerEventLogByTransactionDateDataSetTableAdapters.FindServerEventLogByTransactionDateTableAdapter aFindServerEventLogByTransactionDateTableAdapter;

        FindServerEventLogByNoteKeywordDataSet aFindServerEventLogByNoteKeywordDataSet;
        FindServerEventLogByNoteKeywordDataSetTableAdapters.FindServerLogByNoteKeywordTableAdapter aFindServerEVentLogByNoteKeywordTableAdapter;

        ServerLogAccessDataSet aServerLogAccessDataSet;
        ServerLogAccessDataSetTableAdapters.serverlogaccessTableAdapter aServerLogAccessTableAdapter;

        FindServerEventLogMaxDateDataSet aFindServerEventLogMaxDateDataSet;
        FindServerEventLogMaxDateDataSetTableAdapters.FindServerEventLogMaxDateTableAdapter aFindServerEVentLogMaxDateTableAdapter;

        InsertServerLogAccessEntryTableAdapters.QueriesTableAdapter aInsertServerLogAccessTableAdapter;

        FindServerLogAccessByEmployeeIDDataSet aFindServerLogAccessByEmployeeIDDataSet;
        FindServerLogAccessByEmployeeIDDataSetTableAdapters.FindServerLogAccessByEmmployeeIDTableAdapter aFindServerLogAccessByEmployeeIDTableAdapter;

        DeactivateEmployeeServerLogAccessDataSetTableAdapters.QueriesTableAdapter aDeactivateEmployeeServerLogAccessTableAdapter;

        FindServerEventLogContentMatchDataSet aFindServerEventLogContentMatchDataSet;
        FindServerEventLogContentMatchDataSetTableAdapters.FindServerEventLogByContentMatchTableAdapter aFindServerEventLogContentMatchTableAdapter;

        FindServerEventLogSecurityAccessDataSet aFindServerEventLogSecurityAccessDataSet;
        FindServerEventLogSecurityAccessDataSetTableAdapters.FindServerEventLogSecurityAccessTableAdapter aFindServerEventLogSecurityAccessTableAdapter;

        FindServerEventLogSecurityAccessByKeywordDataSet aFindServerEventLogSecurityAccessByKeywordDataSet;
        FindServerEventLogSecurityAccessByKeywordDataSetTableAdapters.FindServerEventLogSercurityAccessByKeywordTableAdapter aFindServerEventLogSecurityAccessByKeywordTableAdapter;

        FindServerEventLogByDateRangeDataSet aFindServerEventLogByDateRangeDataSet;
        FindServerEventLogByDateRangeDataSetTableAdapters.FindServerEventLogByDateRangeTableAdapter aFindServerEventLogByDateRangeTableAdapter;

        ServerEventLogForReportsDataSet aServerEventLogForReportsDataSet;
        ServerEventLogForReportsDataSetTableAdapters.ServerEventLogForReportsTableAdapter aServerEventLogForReportsTableAdapter;

        InsertServerEventLogForReportsEntryTableAdapters.QueriesTableAdapter aInsertServerEventLogForReportsEntryTableAdapter;

        FindServerEventLogForReportsVerificationDataSet aFindServerEventLogForReportsVerificationDataSet;
        FindServerEventLogForReportsVerificationDataSetTableAdapters.FindServerEventLogForReportsVerificationTableAdapter aFindServerEventLogForReportsVerificationTableAdapter;

        FindServerEventLogForReportsByUserDataSet aFindServerEventLogForReportsByUserDataSet;
        FindServerEventLogForReportsByUserDataSetTableAdapters.FindServerEventLogForReportsByUserTableAdapter aFindServerEventLogForReportsByUserTableAdapter;

        FindServerEventLogForReportsByItemDataSet aFindServerEventLogForReportsByItemDataSet;
        FindServerEventLogForReportsByItemDataSetTableAdapters.FindServerEventLogForReportsByItemTableAdapter aFindServerEventLogForReportsByItemTableAdapter;

        FindServerEventLogForReportsByDateRangeDataSet aFindServerEventLogForReportsByDateRangeDataSet;
        FindServerEventLogForReportsByDateRangeDataSetTableAdapters.FindServerEventLogForReportsByDateRangeTableAdapter aFindServerEventLogForReportsByDateRangeTableAdapter;

        ServerLogSearchTermsDataSet aServerLogSearchTermsDataSet;
        ServerLogSearchTermsDataSetTableAdapters.serverlogsearchtermsTableAdapter aServerLogSearchTermsTableAdapter;

        InsertServerLogSearchTermEntryTableAdapters.QueriesTableAdapter aInsertServerLogSearchTermTableAdapter;

        UpdateServerLogSearchTermActiveEntryTableAdapters.QueriesTableAdapter aUpdateServerLogSearchTermActiveTableAdapter;

        FindActiveServerLogSearchTermsDataSet aFindActiveServerLogSearchTermsDataSet;
        FindActiveServerLogSearchTermsDataSetTableAdapters.FindActiveServerLogSearchTermsTableAdapter aFindActiveServerLogSearchTermsTableAdapter;

        FindSortedServerLogSearchTermsDataSet aFindSortedServerLogSearchTermsDataSet;
        FindSortedServerLogSearchTermsDataSetTableAdapters.FindSortedServerLogSearchTermsTableAdapter aFindSortedServerLogSearchTermsTableAdapter;

        FindServerLogSearchTermDataSet aFindServerLogSeachTermDataSet;
        FindServerLogSearchTermDataSetTableAdapters.FindServerLogSearchTermTableAdapter aFindServerLogSearchTermTableAdapter;

        FindEventLogEntriesForEmailDataSet aFindEventLogEntriesForEmailDataSet;
        FindEventLogEntriesForEmailDataSetTableAdapters.FindEventLogEntriesForEmailTableAdapter aFindEventLogEntriesForEmailTableAdapter;

        FindServerEventLogForReportsEntryDataSet findServerEventLogForReportsEntryDataSet;
        FindServerEventLogForReportsEntryDataSetTableAdapters.FindServerEventLogForReportsEntryTableAdapter aFindServerEventLogForReportsEntryTableAdapter;

        public FindServerEventLogForReportsEntryDataSet FindServerEventLogForReportsEntry()
        {
            try
            {
                findServerEventLogForReportsEntryDataSet = new FindServerEventLogForReportsEntryDataSet();
                aFindServerEventLogForReportsEntryTableAdapter = new FindServerEventLogForReportsEntryDataSetTableAdapters.FindServerEventLogForReportsEntryTableAdapter();
                aFindServerEventLogForReportsEntryTableAdapter.Fill(findServerEventLogForReportsEntryDataSet.FindServerEventLogForReportsEntry);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Event Log Entries For Email " + Ex.ToString());
            }
            return findServerEventLogForReportsEntryDataSet;
            
        }
        public FindEventLogEntriesForEmailDataSet FindEventLogEntriesForEmail()
        {
            try
            {
                aFindEventLogEntriesForEmailDataSet = new FindEventLogEntriesForEmailDataSet();
                aFindEventLogEntriesForEmailTableAdapter = new FindEventLogEntriesForEmailDataSetTableAdapters.FindEventLogEntriesForEmailTableAdapter();
                aFindEventLogEntriesForEmailTableAdapter.Fill(aFindEventLogEntriesForEmailDataSet.FindEventLogEntriesForEmail);
            }
            catch (Exception ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Event Log Entries For Email " + ex.ToString());
            }

            return aFindEventLogEntriesForEmailDataSet;
        }
        public FindServerLogSearchTermDataSet FindServerLogSearchTerm(string strSearchTerm)
        {
            try
            {
                aFindServerLogSeachTermDataSet = new FindServerLogSearchTermDataSet();
                aFindServerLogSearchTermTableAdapter = new FindServerLogSearchTermDataSetTableAdapters.FindServerLogSearchTermTableAdapter();
                aFindServerLogSearchTermTableAdapter.Fill(aFindServerLogSeachTermDataSet.FindServerLogSearchTerm, strSearchTerm);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Log Search Term " + Ex.ToString());
            }

            return aFindServerLogSeachTermDataSet;
        }
        public FindSortedServerLogSearchTermsDataSet FindSortedServerLogSearchTerms()
        {
            try
            {
                aFindSortedServerLogSearchTermsDataSet = new FindSortedServerLogSearchTermsDataSet();
                aFindSortedServerLogSearchTermsTableAdapter = new FindSortedServerLogSearchTermsDataSetTableAdapters.FindSortedServerLogSearchTermsTableAdapter();
                aFindSortedServerLogSearchTermsTableAdapter.Fill(aFindSortedServerLogSearchTermsDataSet.FindSortedServerLogSearchTerms);
            }
            catch(Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Sorted Server Log Search Terms " + Ex.ToString());
            }

            return aFindSortedServerLogSearchTermsDataSet;
        }
        public FindActiveServerLogSearchTermsDataSet FindActiveServerLogSearchTerms()
        {
            try
            {
                aFindActiveServerLogSearchTermsDataSet = new FindActiveServerLogSearchTermsDataSet();
                aFindActiveServerLogSearchTermsTableAdapter = new FindActiveServerLogSearchTermsDataSetTableAdapters.FindActiveServerLogSearchTermsTableAdapter();
                aFindActiveServerLogSearchTermsTableAdapter.Fill(aFindActiveServerLogSearchTermsDataSet.FindActiveServerLogSearchTerms);
            }
            catch (Exception ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Active Server Log Search Terms " + ex.ToString());
            }

            return aFindActiveServerLogSearchTermsDataSet;
        }
        public bool UpdateServerLogSearchTermActive(int intTransactionID, bool blnTermActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateServerLogSearchTermActiveTableAdapter = new UpdateServerLogSearchTermActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdateServerLogSearchTermActiveTableAdapter.UpdateServerLogSearchTermActive(intTransactionID, blnTermActive);
            }
            catch (Exception ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Update Server Log Search Term Active " + ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertServerLogSearchTerm(string strSearchTerm)
        {
            bool blnFatalError = false;

            try
            {
                aInsertServerLogSearchTermTableAdapter = new InsertServerLogSearchTermEntryTableAdapters.QueriesTableAdapter();
                aInsertServerLogSearchTermTableAdapter.InsertServerLogSearchTerm(strSearchTerm, DateTime.Now);
            }
            catch (Exception ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Insert Server Log Search Term " + ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ServerLogSearchTermsDataSet GetServerLogSearchTermsInfo()
        {
            try
            {
                aServerLogSearchTermsDataSet = new ServerLogSearchTermsDataSet();
                aServerLogSearchTermsTableAdapter = new ServerLogSearchTermsDataSetTableAdapters.serverlogsearchtermsTableAdapter();
                aServerLogSearchTermsTableAdapter.Fill(aServerLogSearchTermsDataSet.serverlogsearchterms);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Get Server Log Search Terms Info " + Ex.ToString());
            }

            return aServerLogSearchTermsDataSet;
        }
        public void UpdateServerLogSearchTermsDB(ServerLogSearchTermsDataSet aServerLogSearchTermsDataSet)
        {
            try
            {
                aServerLogSearchTermsTableAdapter = new ServerLogSearchTermsDataSetTableAdapters.serverlogsearchtermsTableAdapter();
                aServerLogSearchTermsTableAdapter.Update(aServerLogSearchTermsDataSet.serverlogsearchterms);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Update Server Log Search Terms DB " + Ex.ToString());
            }
        }
        public FindServerEventLogForReportsByDateRangeDataSet FindServerEventLogForReportsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindServerEventLogForReportsByDateRangeDataSet = new FindServerEventLogForReportsByDateRangeDataSet();
                aFindServerEventLogForReportsByDateRangeTableAdapter = new FindServerEventLogForReportsByDateRangeDataSetTableAdapters.FindServerEventLogForReportsByDateRangeTableAdapter();
                aFindServerEventLogForReportsByDateRangeTableAdapter.Fill(aFindServerEventLogForReportsByDateRangeDataSet.FindServerEventLogForReportsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log For Reports By Date Range " + Ex.ToString());
            }

            return aFindServerEventLogForReportsByDateRangeDataSet;
        }
        public FindServerEventLogForReportsByItemDataSet FindServerEventLogForReportsByItem(string strItemAccessed, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindServerEventLogForReportsByItemDataSet = new FindServerEventLogForReportsByItemDataSet();
                aFindServerEventLogForReportsByItemTableAdapter = new FindServerEventLogForReportsByItemDataSetTableAdapters.FindServerEventLogForReportsByItemTableAdapter();
                aFindServerEventLogForReportsByItemTableAdapter.Fill(aFindServerEventLogForReportsByItemDataSet.FindServerEventLogForReportsByItem, strItemAccessed, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log For Reports By Item " + Ex.ToString());
            }

            return aFindServerEventLogForReportsByItemDataSet;
        }
        public FindServerEventLogForReportsByUserDataSet FindServerEventLogForReportsByUser(string strLogonName, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindServerEventLogForReportsByUserDataSet = new FindServerEventLogForReportsByUserDataSet();
                aFindServerEventLogForReportsByUserTableAdapter = new FindServerEventLogForReportsByUserDataSetTableAdapters.FindServerEventLogForReportsByUserTableAdapter();
                aFindServerEventLogForReportsByUserTableAdapter.Fill(aFindServerEventLogForReportsByUserDataSet.FindServerEventLogForReportsByUser, strLogonName, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log For Reports By User " + Ex.ToString());
            }

            return aFindServerEventLogForReportsByUserDataSet;
        }
        public FindServerEventLogForReportsVerificationDataSet FindServerEventLogForReportsVerification(DateTime datTransactionDate, string strLogonName, string strItemAccessed)
        {
            try
            {
                aFindServerEventLogForReportsVerificationDataSet = new FindServerEventLogForReportsVerificationDataSet();
                aFindServerEventLogForReportsVerificationTableAdapter = new FindServerEventLogForReportsVerificationDataSetTableAdapters.FindServerEventLogForReportsVerificationTableAdapter();
                aFindServerEventLogForReportsVerificationTableAdapter.Fill(aFindServerEventLogForReportsVerificationDataSet.FindServerEventLogForReportsVerification, datTransactionDate, strLogonName, strItemAccessed);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Eventlog For Reports Verification " + Ex.ToString());
            }

            return aFindServerEventLogForReportsVerificationDataSet;
        }
        public bool InsertServerEventLogForReports(DateTime datTransactionDate, string strLogonName, string strItemAccessed)
        {
            bool blnFatalError = false;

            try
            {
                aInsertServerEventLogForReportsEntryTableAdapter = new InsertServerEventLogForReportsEntryTableAdapters.QueriesTableAdapter();
                aInsertServerEventLogForReportsEntryTableAdapter.InsertServerEventLogForReports(datTransactionDate, strLogonName, strItemAccessed);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Insert Server Event Log For Reports " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ServerEventLogForReportsDataSet GetServerEventLogForReportsDB()
        {
            try
            {
                aServerEventLogForReportsDataSet = new ServerEventLogForReportsDataSet();
                aServerEventLogForReportsTableAdapter = new ServerEventLogForReportsDataSetTableAdapters.ServerEventLogForReportsTableAdapter();
                aServerEventLogForReportsTableAdapter.Fill(aServerEventLogForReportsDataSet.ServerEventLogForReports);
            }
            catch (Exception ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Get Server Event Log For Reports DB " + ex.ToString());
            }

            return aServerEventLogForReportsDataSet;
        }
        public void UpdateServerEventLogForReportsDB(ServerEventLogForReportsDataSet aServerEventLogForReportsDataSet)
        {
            try
            {
                aServerEventLogForReportsTableAdapter = new ServerEventLogForReportsDataSetTableAdapters.ServerEventLogForReportsTableAdapter();
                aServerEventLogForReportsTableAdapter.Update(aServerEventLogForReportsDataSet.ServerEventLogForReports);
            }
            catch (Exception ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Update Server Event Log For Reports DB " + ex.ToString());
            }
        }

        public FindServerEventLogByDateRangeDataSet FindServerEventLogByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindServerEventLogByDateRangeDataSet = new FindServerEventLogByDateRangeDataSet();
                aFindServerEventLogByDateRangeTableAdapter = new FindServerEventLogByDateRangeDataSetTableAdapters.FindServerEventLogByDateRangeTableAdapter();
                aFindServerEventLogByDateRangeTableAdapter.Fill(aFindServerEventLogByDateRangeDataSet.FindServerEventLogByDateRange, datStartDate, datEndDate);
            }
            catch (Exception ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log by Date Range " + ex.ToString());
            }

            return aFindServerEventLogByDateRangeDataSet;
        }
        public FindServerEventLogSecurityAccessByKeywordDataSet FindServerEventLogSecurityByKeyword(string strKeyword, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindServerEventLogSecurityAccessByKeywordDataSet = new FindServerEventLogSecurityAccessByKeywordDataSet();
                aFindServerEventLogSecurityAccessByKeywordTableAdapter = new FindServerEventLogSecurityAccessByKeywordDataSetTableAdapters.FindServerEventLogSercurityAccessByKeywordTableAdapter();
                aFindServerEventLogSecurityAccessByKeywordTableAdapter.Fill(aFindServerEventLogSecurityAccessByKeywordDataSet.FindServerEventLogSercurityAccessByKeyword, strKeyword, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log Security Access by Keyword " + Ex.ToString());
            }

            return aFindServerEventLogSecurityAccessByKeywordDataSet;
        }
        public FindServerEventLogSecurityAccessDataSet FindServerEventLogSecurityAccess()
        {
            try
            {
                aFindServerEventLogSecurityAccessDataSet = new FindServerEventLogSecurityAccessDataSet();
                aFindServerEventLogSecurityAccessTableAdapter = new FindServerEventLogSecurityAccessDataSetTableAdapters.FindServerEventLogSecurityAccessTableAdapter();
                aFindServerEventLogSecurityAccessTableAdapter.Fill(aFindServerEventLogSecurityAccessDataSet.FindServerEventLogSecurityAccess);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log Security Access " + Ex.ToString());
            }

            return aFindServerEventLogSecurityAccessDataSet;
        }
        public FindServerEventLogContentMatchDataSet FindServerEventLogContentMatch(string strEventNotes, string strEventCategory, DateTime datTransactionDate)
        {
            try
            {
                aFindServerEventLogContentMatchDataSet = new FindServerEventLogContentMatchDataSet();
                aFindServerEventLogContentMatchTableAdapter = new FindServerEventLogContentMatchDataSetTableAdapters.FindServerEventLogByContentMatchTableAdapter();
                aFindServerEventLogContentMatchTableAdapter.Fill(aFindServerEventLogContentMatchDataSet.FindServerEventLogByContentMatch, strEventNotes, strEventCategory, datTransactionDate);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log Content Match " + Ex.ToString());
            }

            return aFindServerEventLogContentMatchDataSet;
        }
        public bool DeactivateEmployeeServerLogAccessEntry(int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aDeactivateEmployeeServerLogAccessTableAdapter = new DeactivateEmployeeServerLogAccessDataSetTableAdapters.QueriesTableAdapter();
                aDeactivateEmployeeServerLogAccessTableAdapter.DeactivateEmployeeServerLogAccess(intEmployeeID);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Deactive Employee Server Log Access Entry " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindServerLogAccessByEmployeeIDDataSet FindServerLogAccessByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindServerLogAccessByEmployeeIDDataSet = new FindServerLogAccessByEmployeeIDDataSet();
                aFindServerLogAccessByEmployeeIDTableAdapter = new FindServerLogAccessByEmployeeIDDataSetTableAdapters.FindServerLogAccessByEmmployeeIDTableAdapter();
                aFindServerLogAccessByEmployeeIDTableAdapter.Fill(aFindServerLogAccessByEmployeeIDDataSet.FindServerLogAccessByEmmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Log Access By Employee ID " + Ex.ToString());
            }

            return aFindServerLogAccessByEmployeeIDDataSet;
        }
        public bool InsertServerLogAccess(int intEmployeeID, DateTime datCreationDate, int intEnteredEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertServerLogAccessTableAdapter = new InsertServerLogAccessEntryTableAdapters.QueriesTableAdapter();
                aInsertServerLogAccessTableAdapter.InsertServerLogAccess(intEmployeeID, datCreationDate, intEnteredEmployeeID);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Insert Server Log Access " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindServerEventLogMaxDateDataSet FindServerEventLogMaxDate()
        {
            try
            {
                aFindServerEventLogMaxDateDataSet = new FindServerEventLogMaxDateDataSet();
                aFindServerEVentLogMaxDateTableAdapter = new FindServerEventLogMaxDateDataSetTableAdapters.FindServerEventLogMaxDateTableAdapter();
                aFindServerEVentLogMaxDateTableAdapter.Fill(aFindServerEventLogMaxDateDataSet.FindServerEventLogMaxDate);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log Max Date " + Ex.ToString());
            }

            return aFindServerEventLogMaxDateDataSet;
        }
        public ServerLogAccessDataSet GetServerLogAccessInfo()
        {
            try
            {
                aServerLogAccessDataSet = new ServerLogAccessDataSet();
                aServerLogAccessTableAdapter = new ServerLogAccessDataSetTableAdapters.serverlogaccessTableAdapter();
                aServerLogAccessTableAdapter.Fill(aServerLogAccessDataSet.serverlogaccess);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Get Server Log Access Info " + Ex.ToString());
            }

            return aServerLogAccessDataSet;
        }
        public void UpdateServerLogAccessDB(ServerLogAccessDataSet aServerLogAccessDataSet)
        {
            try
            {
                aServerLogAccessTableAdapter = new ServerLogAccessDataSetTableAdapters.serverlogaccessTableAdapter();
                aServerLogAccessTableAdapter.Update(aServerLogAccessDataSet.serverlogaccess);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Get Server Log Access Info " + Ex.ToString());
            }
        }
        public FindServerEventLogByNoteKeywordDataSet FindServerEventLogByNoteKeyword(string strNoteKeyword, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindServerEventLogByNoteKeywordDataSet = new FindServerEventLogByNoteKeywordDataSet();
                aFindServerEVentLogByNoteKeywordTableAdapter = new FindServerEventLogByNoteKeywordDataSetTableAdapters.FindServerLogByNoteKeywordTableAdapter();
                aFindServerEVentLogByNoteKeywordTableAdapter.Fill(aFindServerEventLogByNoteKeywordDataSet.FindServerLogByNoteKeyword, strNoteKeyword, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log By Note Keyword " + Ex.ToString());
            }

            return aFindServerEventLogByNoteKeywordDataSet;
        }
        public FindServerEventLogByTransactionDateDataSet FindServerEventLogByTransactionDate(DateTime datTransactionDate)
        {
            try
            {
                aFindServerEventLogByTransactionDateDataSet = new FindServerEventLogByTransactionDateDataSet();
                aFindServerEventLogByTransactionDateTableAdapter = new FindServerEventLogByTransactionDateDataSetTableAdapters.FindServerEventLogByTransactionDateTableAdapter();
                aFindServerEventLogByTransactionDateTableAdapter.Fill(aFindServerEventLogByTransactionDateDataSet.FindServerEventLogByTransactionDate, datTransactionDate);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Find Server Event Log By Transaction Date " + Ex.ToString());
            }

            return aFindServerEventLogByTransactionDateDataSet;
        }
        public bool InsertServerEventLog(DateTime datTransactionDate, string strEventCategory, string strEventNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertServerEventLogEntryTableAdapter = new InsertServerEventLogEntryTableAdapters.QueriesTableAdapter();
                aInsertServerEventLogEntryTableAdapter.InsertServerEventLog(datTransactionDate, strEventCategory, strEventNotes, DateTime.Now);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // inserst Server Event Log " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ServerEventLogDataSet GetServerEventLogInfo()
        {
            try
            {
                aServerEventLogDataSet = new ServerEventLogDataSet();
                aServerEventLogTableAdapter = new ServerEventLogDataSetTableAdapters.servereventlogTableAdapter();
                aServerEventLogTableAdapter.Fill(aServerEventLogDataSet.servereventlog);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Get Server Event Log Info " + Ex.ToString());
            }

            return aServerEventLogDataSet;
        }
        public void UpdateServerEventLogDB(ServerEventLogDataSet aServerEventLogDataSet)
        {
            try
            {
                aServerEventLogTableAdapter = new ServerEventLogDataSetTableAdapters.servereventlogTableAdapter();
                aServerEventLogTableAdapter.Update(aServerEventLogDataSet.servereventlog);
            }
            catch (Exception Ex)
            {
                InsertEventLogEntry(DateTime.Now, "Event Log Class // Update Server Event Log DB " + Ex.ToString());
            }
        }
        public FindEventLogByDateRangeDataSet FindEventLogByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEventLogByDateRangeDataSet = new FindEventLogByDateRangeDataSet();
                aFindEventLogByDateRangeTableAdapter = new FindEventLogByDateRangeDataSetTableAdapters.FindEventLogEntriesByDateRangeTableAdapter();
                aFindEventLogByDateRangeTableAdapter.Fill(aFindEventLogByDateRangeDataSet.FindEventLogEntriesByDateRange, datStartDate, datEndDate);
            }
            catch (Exception)
            {
                
            }

            return aFindEventLogByDateRangeDataSet;
        }
        public bool InsertEventLogEntry(DateTime datEventDate, string strEventLogEntry)
        {
            bool blnFatalError = false;
            string strComputerName;
            string strUser;

            try
            {
                strComputerName = System.Environment.MachineName;
                strUser = System.Environment.UserName;

                strEventLogEntry = strUser + " " + strComputerName + " " + strEventLogEntry;

                aInsertEventLogEntry = new InsertEventLogEntry();
                aInsertEventLogTableAdapter = new InsertEventLogEntryTableAdapters.QueriesTableAdapter();
                aInsertEventLogTableAdapter.InsertEventLogEntry(datEventDate, strEventLogEntry);

            }
            catch (Exception Ex)
            {
                aInsertEventLogTableAdapter.InsertEventLogEntry(datEventDate, Ex.ToString());
            }

            return blnFatalError;
        }
        public EventLogDataSet GetEventLogInfo()
        {
            try
            {
                aEventLogDataSet = new EventLogDataSet();
                aEventLogTableAdapter = new EventLogDataSetTableAdapters.eventlogTableAdapter();
                aEventLogTableAdapter.Fill(aEventLogDataSet.eventlog);
            }
            catch (Exception)
            {

            }

            return aEventLogDataSet;
        }
        public void UpdateEventLogDB(EventLogDataSet aEventLogDataSet)
        {
            try
            {
                aEventLogTableAdapter = new EventLogDataSetTableAdapters.eventlogTableAdapter();
                aEventLogTableAdapter.Update(aEventLogDataSet.eventlog);
            }
            catch (Exception)
            {

            }
        }
        
    }
}
