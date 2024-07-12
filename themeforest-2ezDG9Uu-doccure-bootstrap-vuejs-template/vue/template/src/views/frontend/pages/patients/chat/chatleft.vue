<template>
	<div class="chat-cont-left">
		<div class="chat-header">
			<span>Chats</span>
			<a href="javascript:void(0)" class="chat-compose">
				<i class="material-icons">control_point</i>
			</a>
		</div>
		<form class="chat-search">
			<div class="input-group">
				<div class="input-group-prepend">
					<i class="fas fa-search"></i>
				</div>
				<input type="text" class="form-control rounded-pill" placeholder="Search" />
			</div>
		</form>
		<div class="chat-users-list">
			<div class="chat-scroll">
				<a href="javascript:void(0);" class="notify-block d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-away">
							<img src="@/assets/img/doctors/doctor-thumb-01.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Ruby Perrin</div>
							<div class="user-last-chat">Hey, How are you?</div>
						</div>
						<div>
							<div class="last-chat-time block">2 min</div>
							<div class="badge badge-success rounded-pill">15</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block read-chat active d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-online">
							<img src="@/assets/img/doctors/doctor-thumb-02.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Darren Elder</div>
							<div class="user-last-chat">I'll call you later </div>
						</div>
						<div>
							<div class="last-chat-time block">8:01 PM</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-away">
							<img src="@/assets/img/doctors/doctor-thumb-03.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Deborah Angel</div>
							<div class="user-last-chat">Give me a full explanation about our project</div>
						</div>
						<div>
							<div class="last-chat-time block">7:30 PM</div>
							<div class="badge badge-success rounded-pill">3</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block read-chat d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-online">
							<img src="@/assets/img/doctors/doctor-thumb-04.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Sofia Brient</div>
							<div class="user-last-chat">That's very good UI design</div>
						</div>
						<div>
							<div class="last-chat-time block">6:59 PM</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block read-chat d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-offline">
							<img src="@/assets/img/doctors/doctor-thumb-05.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Marvin Campbell</div>
							<div class="user-last-chat">Yesterday i completed the task</div>
						</div>
						<div>
							<div class="last-chat-time block">11:21 AM</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block read-chat d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-online">
							<img src="@/assets/img/doctors/doctor-thumb-06.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Katharine Berthold</div>
							<div class="user-last-chat">What is the major functionality?</div>
						</div>
						<div>
							<div class="last-chat-time block">10:05 AM</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block read-chat d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-away">
							<img src="@/assets/img/doctors/doctor-thumb-07.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Linda Tobin</div>
							<div class="user-last-chat">This has allowed me to showcase not only my technical skills</div>
						</div>
						<div>
							<div class="last-chat-time block">Yesterday</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block read-chat d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-offline">
							<img src="@/assets/img/doctors/doctor-thumb-08.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Paul Richard</div>
							<div class="user-last-chat">Let's talk briefly in the evening. </div>
						</div>
						<div>
							<div class="last-chat-time block">Sunday</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block read-chat d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-online">
							<img src="@/assets/img/doctors/doctor-thumb-09.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. John Gibbs </div>
							<div class="user-last-chat">Do you have any collections? If so, what of?</div>
						</div>
						<div>
							<div class="last-chat-time block">Saturday</div>
						</div>
					</div>
				</a>
				<a href="javascript:void(0);" class="notify-block read-chat d-flex">
					<div class="media-img-wrap flex-shrink-0">
						<div class="avatar avatar-away">
							<img src="@/assets/img/doctors/doctor-thumb-10.jpg" alt="User Image"
								class="avatar-img rounded-circle">
						</div>
					</div>
					<div class="media-body flex-grow-1">
						<div>
							<div class="user-name">Dr. Olga Barlow</div>
							<div class="user-last-chat">Connect the two modules with in 1 day.</div>
						</div>
					<div>
						<div class="last-chat-time block">Friday</div>
					</div>
				</div>
			</a>
		</div>
	</div>
</div></template>