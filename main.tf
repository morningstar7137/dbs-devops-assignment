provider "aws" {
  region = "eu-west-1"
}

# Create a Security Group to allow SSH and Web Traffic
resource "aws_security_group" "dbs_sg" {
  name = "dbs_assignment_sg"

  ingress {
    from_port   = 22
    to_port     = 22
    protocol    = "tcp"
    cidr_blocks = ["0.0.0.0/0"] # Allow SSH access
  }

  ingress {
    from_port   = 80
    to_port     = 80
    protocol    = "tcp"
    cidr_blocks = ["0.0.0.0/0"] # Allow HTTP access for your Docker app
  }

  egress {
    from_port   = 0
    to_port     = 0
    protocol    = "-1"
    cidr_blocks = ["0.0.0.0/0"]
  }
}

# Launch the EC2 Instance
resource "aws_instance" "dbs_server" {
  ami           = "ami-0c02fb55956c7d316" # Correct AMI for Ireland (eu-west-1)
  instance_type = "t3.micro"             # Matches your console preference
  key_name      = "DBS-Assignment-Key"   # Matches the key in your folder
  vpc_security_group_ids = [aws_security_group.dbs_sg.id]

  tags = {
    Name = "DBS-DevOps-AppServer"
  }
}