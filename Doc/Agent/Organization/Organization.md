# Organization
**DTMI:** dtmi:org:w3id:rec:Organization;1
## Display name
- **en:** Organization
## Description
- **en:** An organization of any sort (e.g., a business, association, project, consortium, tribe, etc.)
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|
|-|-|-|-|-|-|
|hasMember|**en**: has member|**en**: Indicates membership in an organization. Note that componency (e.g., departments of a corporation) are expressed using the more generic hasPart property.|0-Infinity|dtmi:org:w3id:rec:Agent;1|
|hasPart|**en**: has part|**en**: Indicates parthood relations in organizations (e.g., departments of a corporation). Note that membership in an organization is expressed using the more specific hasMember property.|0-Infinity|dtmi:org:w3id:rec:Organization;1|
|isPartOf|**en**: is part of|**en**: Indicates parthood relations in organizations (e.g., departments of a corporation). Note that membership in an organization is expressed using the Agent.isMemberOf property.|0-Infinity|dtmi:org:w3id:rec:Organization;1|
## Properties
## Telemetries
## Commands
