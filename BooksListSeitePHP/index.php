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

<meta http-equiv="refresh" content="5">
</head>
<body>	

	
<?php

	if(isset($_GET['user_edit'])){
				
		$id = $_GET['user_edit'];
					$sql = mysqli_query($conn , " select * from users where id = '$BookID' ");
					$user= mysqli_fetch_assoc($sql);
		
		echo '
<div class="modal fade" id="edit" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalCenterTitle">Edit Book</h5>
        <button type="button" class="close" onclick="goBack()" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
	  
		
      </div>
    </div>
  </div>
</div>				
		';
	}
	
?>
	
	<h1 style="font-size: 25px;text-align: center;margin: 20px;color: #f00;">Books List</h1>
        <h1 style="font-size: 25px;text-align: center;margin: 20px;color:#32CD32;">EC2 Web Server (1)</h1>
	<table class="table">
	  <thead>
		<tr>
		  <th scope="col">#</th>
	          <th scope="col">Book ID</th>
		  <th scope="col">Book Name and Description</th>
		  <th scope="col">Author</th>
                  <th scope="col">Download Link</th>
                  <th scope="col">Download</th>

                 </tr>
	  </thead>
	    <tbody>
           
           <?php
	

		$sql = mysqli_query($conn ,"select * from Book ");
		$num = 1;
		while($user = mysqli_fetch_assoc($sql)){
			echo '
					<tr>
					  <th scope="row">'.$num++.'</th>
                      <td>'.$user['BookID'].'</td>
					  <td>'.$user['BookName'].'</td>
					  <td>'.$user['Author'].'</td>
					  <td>'.$user['Description'].'</td>
          			  <td><a href="'.$user['Description'].'" class="btn btn-warning">Download</a></td>
					</tr>
			';
		}	
	?>
	           </tbody>
               
</table>
	
	
<script type="text/javascript">
    $(window).on('load',function(){
        $('#edit').modal('show');
    });
</script>
	
	
<script>
function goBack() {
    window.history.back();
}
</script>


<script>
$('#edit').modal({
backdrop: 'static',
keyboard: false
})
</script>

</body>
</html>
