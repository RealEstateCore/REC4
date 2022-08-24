[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Deadband_Setpoint](Deadband_Setpoint.md) > [Humidity_Deadband_Setpoint](.)
# Humidity_Deadband_Setpoint

**Display name:** Humidity Deadband Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Deadband_Setpoint;1

---
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
