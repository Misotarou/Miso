#pragma strict

var speed : float = 0.0;
var jumpSpeed : float = 0.0;
var gravity : float = 0.0;

private var moveDirection : Vector3 = Vector3.zero;
private var controller:CharacterController;

function Start()
{
	controller = GetComponent(CharacterController);
}


function Update() 
{
	//地面についているかどうか 
	if (controller.isGrounded) {
		
		//移動方向を取得 
		moveDirection = Vector3(Input.GetAxis("Horizontal"), 0, 0);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		
		//ジャンプ 
		if (Input.GetButton ("Jump")) {
			moveDirection.y = jumpSpeed;
		}
	}
	
	// 重力を計算 
	moveDirection.y -= gravity * Time.deltaTime;
	
	// 移動 
	controller.Move(moveDirection * Time.deltaTime);
}