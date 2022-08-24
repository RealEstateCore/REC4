[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Speed_Setpoint](Speed_Setpoint.md) > [Rated_Speed_Setpoint](#)
# Rated_Speed_Setpoint

**Display name:** Rated Speed Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Rated_Speed_Setpoint;1

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
