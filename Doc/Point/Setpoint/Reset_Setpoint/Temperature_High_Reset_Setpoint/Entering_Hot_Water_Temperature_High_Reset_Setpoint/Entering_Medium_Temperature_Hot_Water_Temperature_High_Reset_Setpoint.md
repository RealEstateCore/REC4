[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Reset_Setpoint](../../Reset_Setpoint.md) > [Temperature_High_Reset_Setpoint](../Temperature_High_Reset_Setpoint.md) > [Entering_Hot_Water_Temperature_High_Reset_Setpoint](Entering_Hot_Water_Temperature_High_Reset_Setpoint.md) > [Entering_Medium_Temperature_Hot_Water_Temperature_High_Reset_Setpoint](.)
# Entering_Medium_Temperature_Hot_Water_Temperature_High_Reset_Setpoint
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Medium_Temperature_Hot_Water_Temperature_High_Reset_Setpoint;1
## Display name
- **en:** Entering Medium Temperature Hot Water Temperature High Reset Set
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