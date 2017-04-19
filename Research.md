# ContextAwareSOA_in_IoT
Penn State Behrend-Sigma Xi Undergraduate Student Research Project - Implementation

### Abstract 
The Internet of Things has gained extraordinary popularity recently and is only expected to grow in the coming years. Being able to receive data and information from Things anywhere in the world will bring big changes in every facet of people’s daily lives. These Things are service providers themselves. A user should be able to find a Thing and ask for a service that will be provided by the Thing. But what happens when the number of Things become so large? How will the user be able to find and select these Things? How will users select the most appropriate and beneficial smart object to carry out a given task? All of these are some of challenges that are rising from the popularity of the Internet of Things. This research will investigate the above questions and try solve them using two well established computer science concepts; Service-oriented Architecture (SOA) and context-awareness. The goal of this research will be to introduce a Service-oriented Context-aware Architecture for the publication and provision of services in the Internet of Things. A prototype implementation of the architecture will also be introduced.


### Background
In order for this architecture to be developed, it is important to know about the Internet of Things, Service Oriented Architecture, and Context-Awareness and how they all relate.  The Internet of Things (IoT) [1] is the connection of physical objects that collect and transfer data from one object to another. These objects are embedded with software, and sensors; and the objects can be virtually anything. The idea of the Internet of Things is a massive fundamental shift. The numerous possibilities of new products and services are allowed by these intelligent objects. The Internet of Things is expected to change the day to day operations of virtually everything. IoT can be divided into 5 broad categories: [1] smart wearable, smart home, smart city, smart environment, and smart enterprise. Most communication will happen between sensors and machines. These sensors gather data, and then communicate that to another object that can then analyze the data and make decisions based off of this. Most of these critical applications [2] are cloud-based. These applications [2] are key in receiving the data, interpreting it, and transmitting it to create useful information and decisions. 
The next important concept to consider is Service Oriented Architecture. Service oriented architecture (SOA) is a [3] collection, communication, and sharing of services.  In this case, a service is a task well defined, that does not depend on the state of other services. Services can work with other services however they are not concerned with the technical details of the other service. Some benefits [5] to SOA include: platform independence, code reuse, easier testability, easier developer focus, and parallel development. SOA consists of three entities. [4] A service provider, a service registry, and a service requester. In this architecture, Smart Things will be considered as independent, discoverable services.  
The third concept to understand is context-aware. Context is an important concept [6] to consider when designing and implementing software. With the emergence of IoT, context [7] has become even more important. Some questions to ask when determining context is who will be using it, why, when, where, and what. It also consists of more specific aspects such as [8] location, time, temperature, even user’s emotions and preferences; these can be classified as scalar, vector, or abstract values. Being context-aware is having a system acknowledge context from both the user and Thing, and then use that context in a meaningful manner to make decisions and carry out tasks.  



### Introduction
The Internet of Things is turning into an explosive topic in today’s technology world. Smart Things are becoming more prevalent in both business and personal use. From cell phones, smart homes, smart sensors and more [1]; nearly every object can be made intelligent and relay information and data to a user at a moment’s notice. Billions [2] of new smart objects are expected to take hold in the next 5 years. Each of these Things can provide functionality or service to a user or client. You don’t have to own the Thing to get the functionality. A user should be able to search for Things that provide his required functionality. But with the massive growth of smart Things, it will become difficult for users to find these smart Things and more importantly find one or many that best meets the user’s requirements. 
For example, a person driving a vehicle downtown looking for a parking spot. How will the user find an open parking spot without having to drive around and look? How will the user find the most convenient parking spot; one that is near, open, within the driver’s budget, and the size of the spot aligns with the type of vehicle they are driving. Smart Parking Lots and Smart Parking Spaces can be used to determine if a parking spot is open. This information paired with the location, time, fee, and spot size can be used to match a driver with a spot that meets their requirements and then directs them to the spot.  The final question is, can this be accomplished using current architecture for the Internet of Things? 
Service Oriented Architecture [3] can be thought of as a group of individual services that blend and interchange with other services seamlessly, to accomplish a task. Context awareness [4] is the ability to detect and respond to changes in context. Context [5] is the conditions that are used to describe a product, or service. By using a Service Oriented Architecture that is made context aware, this research aims to solve the Internet of Things challenges discussed above. 


### Problem Statement and Research Plan
In the Internet of Things, Things provide services or functionality. A user does not need to own a Thing to get a functionality. A user should be able to search for all available Things. But for this process to work, the owner of the Thing should make the Thing information public and the user of Thing should be able to find it. With the current architecture of the Internet of Things this is not possible. This research plans to investigate, achieving the publication and discovery of Things using Service Oriented Architecture. Combining this with the Internet of Things will allow users to request and receive information from services and smart objects that were once thought to be an arduous task, in seconds without even knowing how it was done. The possibilities are nearly endless. 
However, as the number of Things and users increase, it will become difficult to pair a Thing with a user. It will become even more difficult to find a smart object that will meet the user’s requirements and context. Because of this, the process will become time consuming and less efficient. In order to find the Thing that will provide the user with the most accurate information, the matching process between the user requirements and available Things must consider context. Some examples of context with regards to users are location, time, weather, mood, age, etc. With context awareness, these smart Things will publish their context; and Things will be selected using the context of the Thing and user.
This research aims to solve the problem of scalable publishing and discovery of smart Things using a Service oriented Architecture. It will also aim to solve the problem of scalable matching and discovery of available Things with the use of context-awareness. The result will be a Context Aware Service Oriented Architecture that will allow users to pair with Things based on their context and requirements. This will lead to more accurate data and information coming from smart objects and services. This will also decrease the time the user spends searching for the services and Things they need to use.  


### Related Work
The Internet of Things has gained extraordinary popularity recently and is only expected to grow in the coming years. Being able to receive data and information from Things anywhere in the world will bring big changes in every facet of people’s daily lives. These Things are service providers themselves. A user should be able to find a Thing and ask for a service that will be provided by the Thing. But what happens when the number of Things become so large? How will the user be able to find and select these Things? How will users select the most appropriate and beneficial smart object to carry out a given task? All of these are some of challenges that are rising from the popularity of the Internet of Things. This research will investigate the above questions and try solve them using two well established computer science concepts; Service-oriented Architecture (SOA) and context-awareness. The goal of this research will be to introduce a Service-oriented Context-aware Architecture for the publication and provision of services in the Internet of Things. A prototype implementation of the architecture will also be introduced.
Context, scalability, dynamic context, discovery, search, rank, and formality were the criteria used to review the following research articles. Each of these criteria will be crucial for developing the architecture. Context and dynamic context provide useful information that can be interpreted. This needs to come from both the Thing and the user. Providing context, especially dynamic context which is always changing, from the Thing and user will allow the user to be matched up with the best Thing for the individual user. 
Scalability is another important factor. As the size of Things increase drastically, it will be important that the architecture can adapt and scale with this increase. Also in this case, scalability can mean that the architecture will be platform independent, and can also incorporate a diverse classification of Things. 
In order for a user to find these Things, the architecture must support the discovery of Things, which in this architecture these Things will be represented as services. Now that a user has access to finding these services, there will have to be a way to search for these. Being able to search will provide the user with an easier time to find the service they are looking for. However, this process will be far too time consuming with the increase in smart Things being published. To really make this architecture useful, the context of the service and user will be ranked. This ranking will decrease the amount of time the user spends searching for the service they desire. This ranking will also provide the user with the most accurate service for them based off of their context and needs. Now, the user has access to the most accurate data possible, so that they can carry out their task with the most efficiency. 
The last criteria used to classify the articles is formality. This means that not only is there an idea or architecture, but it is supported by use-cases, facts, algorithms, and or mathematics.  In summary, each article will be reviewed with these 6 criteria in mind. The information gathered will prove that there is a need for this architecture once the amount of Things added increases, and that this architecture currently does not exist. 
The first article [9] aims to integrate business systems with their manufacturing and logistics processes. This architecture does consider discovery, search, and rank of Things by using a service catalogue and ranking services and Things based off the program needs during runtime. It is also uses web services, which allows this to be scalable. However, this architecture does not consider context at all. 
Another research article [10] looks at IOT interacting with the environment. This is caused by the environment creating events, rather than receiving input from the user. This architecture does allow discovery and search-ability of Things using an IOT Browser but does not have a way to rank them. The browser also allows users to view statistics and certain context on sensors and devices based on current events. And the events themselves are viewable and dynamic in nature. This article is formal, and does show some coding and algorithms, as well as a test which proves that their architecture is faster than standard SOA by about 4000 milliseconds. This research does not consider scalability however. 
The focus of the next article [11] is to consider IOT as resources and to build an architecture for that. Like other articles, this one does consider discovery by using a service broker, but there is no mention of being able to search or rank these services. Among discovery, researchers also allow for scalability in their architecture by using the Web of Things. This article also does not consider any type of context. 
In a Discovery Driven SOA article [12], there is discovery of Things, applications, and middleware. However, no mention of being able to rank these, and only a brief mention of being able to search for these using a query. By using SOA for services, middleware, computing, storage, and applications there is a lot of scalability with this architecture. There was no consideration of context.  
The last article [13] is heavily concerned with dynamic context-awareness through context aware applications. This architecture however, does not allow for any scalability. It also does not allow for any discovery due to its one to one behavior. 
A common theme in all of these architectures is either some type of context awareness and little to no discovery options, or no context with discovery options. None of these architectures support all functionality.  By combining all of the criteria, an architecture can be developed that will better handle the rapid expansion of the Internet of Things. 


### Anticipated Outcomes
The main outcome of this research will be a context-aware service oriented architecture that will supports the publication, discovery and matching of Things in the Internet of Things. This architecture will enable Things owners to publish the information of their Things in a rich definition using context. It will also enable users or consumers to discover these things. A matching that will consider the context of Things and consumers will ensure the best match of the user requirements with available Things. 
A simple illustration of the benefits of this proposed architecture can be shown using the parking spot example. Without this architecture drivers would spend more time driving around and looking for spots, rather than having a Smart Parking Lot communicate with drivers to tell them about open spots. Without context awareness, users would more than likely be directed to a random parking spot that could even be closed. While considering context, a driver will be directed to a spot that is near him and open. The parking attendants are now able to market to a specific base, to customers that are nearby and looking to park. Customers are now able to find the closest open spots without having to think about where they can park. This is just one simple example. The true benefits reside in each unique application. 
The second anticipated outcome is a prototype implementation of the proposed architecture that will be tested with use cases to illustrate its applicability.

### References
"Internet of Things: Science Fiction or Business Fact." Harvard Business Review. Harvard Business School Publishing, 2014. Web. 12 Apr. 2016.
 
Twining, Julianne. "Behind The Numbers: Growth in the Internet of Things." National Cable   & Telecommunications Association. 20 Mar. 2015. Web. 12 Apr. 2016. 
 
"What Is SOA? - SOA and Web Services Explained." India Web Developers. Stylus Systems.  Web. 12 Apr. 2016. 
 
Preuveneers, Davy, and Yolande Berbers. "Internet Of Things: A Context-Awareness Perspective." ITT Today. 12 Mar. 2007. Web. 12 Apr. 2016. 
 
Shamonski, Dorothy. "Internet of Things: Context of Use Just Became More Important." Integrated Computer Solutions. 29 Jan. 2015. Web. 12 Apr. 2016
 
Spiess, P. , Karnouskos, S. , Guinard, D. , Savio, D. , … Trifa, V. SOA-based  Integration of the Internet of Things in Enterprise Services. Retrieved from https://pdfs.semanticscholar.org/07ca/69e52285662f2029e2149ddc40cf827a6704.pdf

Lan, L. , Wang, B. , Zhang, L. , Shi, R. , Li, F. An Event-driven Service-oriented Architecture for Internet of Things Service Execution. Retrieved from http://online-journals.org/index.php/i-joe/article/view/3842

Vujovic, V. , Maksimovic, M. , Kosmajac, D. , Perisic, B. (2015) Resource: A connection between Internet of Things and Resource-Oriented Architecture. Retrieved from https://www.researchgate.net/publication/278685712_Resource_A_connection_between_Internet_of_Things_and_Resource-Oriented_Architecture

Gerogakopoulos, D. , Prakash, P. , Zhang, M. , Ranjan, R. (2015). Discovery-Driven Service Oriented IoT Architecture. Retrieved from https://rranjans.files.wordpress.com/2015/09/cic2015.pdf

Olsson. C. M. , Henfridsson, O. (2005) Designing Context-Aware Interaction: An Action Research Study. Retrieved from https://link.springer.com/chapter/10.1007%2F0-387-28918-6_18#page-1

Internet of things
https://en.wikipedia.org/wiki/Internet_of_things#cite_note-1

The Internet of Things Is Far Bigger Than Anyone Realizes
Daniel Research - http://www.wired.com/insights/2014/11/the-internet-of-things-bigger/

Service-Oriented Architecture (SOA) Definition
Author: Barry-Douglas Barry - http://www.service-architecture.com/articles/web-services/service-oriented_architecture_soa_definition.html

Ibrahim, N. , Ani, I. I. K. A. (2013) An Architecture for Providing and Defining Student-oriented Services. Retrieved from https://www.researchgate.net/publication/268280389_An_Architecture_for_Providing_and_Defining_Student-oriented_Services

http://www.wired.com/insights/2014/11/the-internet-of-things-bigger/ 
http://www.indiawebdevelopers.com/resource_center/articles/soa.html
http://philippe.kruchten.com/2009/07/22/the-context-of-software-development/
http://www.ics.com/blog/internet-things-context-use-just-became-more-important
http://sam.iai.uni-bonn.de/teaching/caaa07/FlorianKronenberg.pdf 
http://home.sandiego.edu/~mjgigli/IoT/SOA-based%20Integration%20of%20the%20Internet%20of%20Things%20in%20Enterprise%20Services.pdf

