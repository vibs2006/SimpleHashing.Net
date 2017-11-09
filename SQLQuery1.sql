select * from M_WebUsersForHash order by 1 desc ;
select top 10 * from M_WebUsersForHash
sp_help M_WebUsersForHash
select USER_NAME, NewPassword, PasswordSalt  from M_WebUsersForHash where USER_NAME like '%vibs2006%'

insert into M_WebUsersForHash values (999999, 'vibs2006@gmail.com','vibs', 'agg', 'CUST', '', '','','', '3453534534534544', 'vibs2006@gmail.com', '', 234567, 0, 1, GETDATE(), 'vibs2006@gmail.com', GETDATE(),'vibs2006@gmail.com', GETDATE(), 1, GETDATE(), 1,1,48,0,'','','','va', 1,'mr', 2, 0, null,null)