<?php

// php code to Insert data into mysql database from input text
if(isset($_POST['insert']))
{
$host 		= 'ls-68880f3e0d856d4fbf541b2e6ef9356b9fb630dc.c779hma5onlz.us-east-1.rds.amazonaws.com' ;
$username 	= 'admin' ;
$password   = '121345eafeD$';
$db_name    = 'dbmaster' ;

    // get values form input text and number

    $BookName = $_POST['BookName'];
    $Author = $_POST['Author'];
    $Description = $_POST['Description'];

    // connect to mysql database using mysqli

    $connect = mysqli_connect($host, $username, $password, $db_name);

    // mysql query to insert data

    $query = "INSERT INTO `Book`(`BookName`, `Author`, `Description`) VALUES ('$BookName','$Author','$Description')";

    $result = mysqli_query($connect,$query);

    // check if mysql query successful

    if($result)
    {
        echo 'Data Inserted';

	echo '<a href="http://35.169.65.117/index.php" class="btn btn-success">   Back</a>';
    }

    else{
        echo 'Data Not Inserted';

    }

    mysqli_free_result($result);
    mysqli_close($connect);
}

?>