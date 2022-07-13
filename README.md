# EnglishLearning

#### 需要配置 nginx , rabbitmq , redis , elasticSearch

location /FileService/ {
			proxy_pass http://localhost:5005/;
			proxy_set_header Host $host;
            proxy_set_header X-Real-IP $remote_addr;
            proxy_set_header X-Real-PORT $remote_port;
            proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
            proxy_set_header X-Forwarded-Proto  $scheme;
            client_max_body_size 100m;
		}
        
        location /IdentityService/ {
			proxy_pass  http://localhost:5004/;
			proxy_set_header Host $host;
            proxy_set_header X-Real-IP $remote_addr;
            proxy_set_header X-Real-PORT $remote_port;
            proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
            proxy_set_header X-Forwarded-Proto  $scheme;
		}
		
		location /Listening.Admin/ {
			proxy_pass http://localhost:5001/;
			proxy_set_header Host $host;
            proxy_set_header X-Real-IP $remote_addr;
            proxy_set_header X-Real-PORT $remote_port;
            proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
            proxy_set_header X-Forwarded-Proto  $scheme;
			proxy_http_version 1.1;
			proxy_set_header Upgrade $http_upgrade;
			proxy_set_header Connection "upgrade";
		}

		location /Listening.Main/ {
			proxy_pass http://localhost:5000/;
			proxy_set_header Host $host;
            proxy_set_header X-Real-IP $remote_addr;
            proxy_set_header X-Real-PORT $remote_port;
            proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;			
            proxy_set_header X-Forwarded-Proto  $scheme;
		}			
		
		location /MediaEncoder/ {
			proxy_pass http://localhost:5003/;
			proxy_set_header Host $host;
            proxy_set_header X-Real-IP $remote_addr;
            proxy_set_header X-Real-PORT $remote_port;
            proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;	
            proxy_set_header X-Forwarded-Proto  $scheme;		
		}

		location /SearchService/ {
			proxy_pass http://localhost:5002/;
			proxy_set_header Host $host;
            proxy_set_header X-Real-IP $remote_addr;
            proxy_set_header X-Real-PORT $remote_port;
            proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
            proxy_set_header X-Forwarded-Proto  $scheme;
		}				
