# Leaving_Medium_Temperature_Hot_Water_Temperature_High_Reset_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Medium_Temperature_Hot_Water_Temperature_High_Reset_Setpoint;1
## Display name
- **en:** Leaving Medium Temperature Hot Water Temperature High Reset Setp
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
