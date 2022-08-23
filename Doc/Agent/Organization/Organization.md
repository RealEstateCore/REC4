# Organization
**DTMI:** dtmi:org:w3id:rec:Organization;1
## Display name
- **en:** Organization
## Description
- **en:** An organization of any sort (e.g., a business, association, project, consortium, tribe, etc.)
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|hasMember|**en**: has member|**en**: Indicates membership in an organization. Note that componency (e.g., departments of a corporation) are expressed using the more generic hasPart property.|0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|hasPart|**en**: has part|**en**: Indicates parthood relations in organizations (e.g., departments of a corporation). Note that membership in an organization is expressed using the more specific hasMember property.|0-Infinity|dtmi:org:w3id:rec:Organization;1||True|
|isPartOf|**en**: is part of|**en**: Indicates parthood relations in organizations (e.g., departments of a corporation). Note that membership in an organization is expressed using the Agent.isMemberOf property.|0-Infinity|dtmi:org:w3id:rec:Organization;1||True|
### Inherited Relationships
* **dtmi:org:w3id:rec:Agent;1:** isMemberOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|logo|**en**: logo|**en**: URL link to an image/logo that represents the organization.|TBD|True|
### Inherited Properties
* **dtmi:org:w3id:rec:Agent;1:** customTags, externalIds, name
## Target Of
* Agent.isMemberOf
* Organization.hasPart
* Organization.isPartOf
