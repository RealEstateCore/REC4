# Max_Unoccupied_Heating_Discharge_Air_Flow_Setpoint_Limit
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Unoccupied_Heating_Discharge_Air_Flow_Setpoint_Limit;1
## Display name
- **en:** Max Unoccupied Heating Discharge Air Flow Setpoint Limit
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|TBD|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
