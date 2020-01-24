<!doctype html>
<?php		include_once('include/config.php');?>
<html>
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
<title>  </title>
<link href="css/bootstrap.min.css" rel="stylesheet">
<link href="css/main-style.css" rel="stylesheet">
<script src="js/jquery-3.3.1.min.js"></script>
<script src="js/popper.min.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="js/fontawesome-all.min.js"></script>
<script src="js/form-jquery.js" type="text/javascript"></script>	
<script src="js/main-js.js"></script>


</head>
<body>	

<form class="container" action="include/inputDataMySql.php" method="post" >

	<h1 style="font-size: 25px;text-align: center;margin: 20px;color: #f00;">Books Input</h1> 
 
 <div class="form-group">
    <label>Book Name</label>
    <input type="text" class="form-control" name="BookName" aria-describedby="emailHelp" placeholder="Enter Book Name">
  </div>
 


 <div class="form-group">
    <label >Author</label>
    <input type="text" class="form-control" name="Author" placeholder="Enter Author Name">
  </div>


<div class="form-group">
    <label >Download Link</label>
    <input type="text" class="form-control" name="Description" placeholder="You must have S3 Link ">
  </div>

 
  <button type="submit" class="btn btn-primary" name="insert">Submit</button>
</form>	
           
         
	
	

</body>
</html>
