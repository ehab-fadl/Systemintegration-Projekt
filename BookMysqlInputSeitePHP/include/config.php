<?php

$host 		= 'ls-68880f3e0d856d4fbf541b2e6ef9356b9fb630dc.c779hma5onlz.us-east-1.rds.amazonaws.com' ; // الهوست
$username 	= 'admin' ; 		// اسم مستخد الهوست
$password   = '121345eafeD$'; // كلمة مرور 
$db_name    = 'dbmaster' ; // اسم قاعدة البيانات

$conn = mysqli_connect( $host , $username , $password , $db_name );
mysqli_set_charset($conn , "utf8");

if (!$conn) {
	echo mysqli_connect_error("خطأ فى الإتصال بقاعدة البيانات") . mysqli_errno();
}

function close_db(){
	global $conn;
	mysqli_close($conn);
}
