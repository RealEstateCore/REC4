[Agent](Agent.md) > [Person](.)
# Person
**DTMI:** dtmi:org:w3id:rec:Person;1
## Display name
- **en:** Person
## Description
- **en:** A natural person (i.e., an individual human being).
## Relationships
### Inherited Relationships
* **dtmi:org:w3id:rec:Agent;1:** isMemberOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|familyName|||string|True|
|gender|**en**: gender||string|True|
|givenName|||string|True|
|image|**en**: image|**en**: URL link to an image that represents the person.|string|True|
### Inherited Properties
* **dtmi:org:w3id:rec:Agent;1:** customTags, externalIds, name
## Target Of
### Inherited
* Asset.commissionedBy
* Asset.installedBy
* Asset.manufacturedBy
* Asset.servicedBy
* Lease.leasee
* Lease.leasor
* Organization.hasMember
* ServiceObject.acknowledgedBy
* ServiceObject.closedBy
* ServiceObject.createdBy
* Architecture.architectedBy
* Architecture.constructedBy
* Architecture.operatedBy
* Architecture.ownedBy
